using System;
namespace Open.Flickr
{
    public interface IFlickrResponse
    {
        string Stat { get; set; }

        int Code { get; set; }

        string Message { get; set; }
    }
}
