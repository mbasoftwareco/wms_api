namespace wms_api.Wrappers
{
    public class WMSResponse<T>
    {
        public WMSResponse() { }
        public WMSResponse(T _data, string _message = null)
        {
            message = _message;
            data = _data;
        }
        public WMSResponse(string _message)
        {
            message = _message;
        }
        public string message { get; set; }
        public T data { get; set; }
    }

}