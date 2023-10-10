using EcommereceWeb.Application.Common;

namespace EcommereceWeb.Application.Interfaces.Common
{
    public interface IResult
    {
        MessageResult Status { get; set; }

    }
    public interface IResult<out T> : IResult
    {

        T Data { get; }

    }
}
