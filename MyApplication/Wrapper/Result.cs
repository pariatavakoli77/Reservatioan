using System.Net;
using System.Security.Policy;

namespace ReservatioanWebApplication.Wrapper;

public record Error(string Code, string Message)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue","A null value was encounterd. ");
    public static readonly Error UserInvalid = new("Error.UserInvalid", "Invalid userName! ");

}

public class Result
{
    //properties
    public bool IsSuccess { get; init; }
    public bool IsFailure => !IsSuccess;
    public string Message { get; set; }
    public HttpStatusCode Status { get; init; }
    public Error? Error { get; set; }

    
    protected Result(bool isSuccess, Error? error, HttpStatusCode status = HttpStatusCode.OK, string? message = null)
    {
        if (isSuccess && error != null && error != Error.None)
            throw new InvalidOperationException("Success result must not have an error.");

        if (!isSuccess && (error is null || error == Error.None))
            throw new InvalidOperationException("Failure result must include an error.");

        IsSuccess = isSuccess;
        Error = error;
        Status = status;
        Message = message;
    }
 
    public static Result Success(HttpStatusCode status = HttpStatusCode.OK, string? message = null) =>
        new(true, Error.None, status, message);

    public static Result Failure(Error error, HttpStatusCode status = HttpStatusCode.InternalServerError, string? message = null) =>
        new(false, error, status, message);

    public static Result<T> Success<T>(T data, HttpStatusCode status = HttpStatusCode.OK, string? message = null) =>
        new(data, true, null, status, message);

    public static Result<T> Failure<T>(Error error, HttpStatusCode status = HttpStatusCode.InternalServerError, string? message = null) =>
        new(default, false, error, status, message);

    public static Result<T> Create<T>(T? value) =>
        value is not null
            ? Success(value)
            : Failure<T>(Error.NullValue);

    public override string ToString() =>
        IsSuccess ? "Success" : $"Failure: {Error?.Code} - {Error?.Message}";


}


public class Result<T> : Result
{
    public T? Data { get; init; }

    internal Result(T? data, bool isSuccess, Error? error, HttpStatusCode status = HttpStatusCode.OK, string? message = null)
        : base(isSuccess, error, status, message)
    {
        Data = data;
    }

    /// <summary>
    /// The Match method in the Result<T> class is inspired by functional programming (especially from languages like F# or Rust), 
    /// and it's used to handle success and failure paths in a clean, declarative way 
    /// — without using if/else 
    /// - or try/catch blocks.
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="onSuccess"></param>
    /// <param name="onFailure"></param>
    /// <returns></returns>
    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<Error, TResult> onFailure) =>
        IsSuccess ? onSuccess(Data!) : onFailure(Error!);
}

