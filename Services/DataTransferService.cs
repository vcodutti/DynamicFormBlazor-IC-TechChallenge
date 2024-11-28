namespace DynamicFormBlazor.Services
{
    public class DataTransferService
    {
        public object? Data { get; private set; }

        public void SetData(object data)
        {
            Data = data;
        }

        public T? GetData<T>() where T : class
        {
            return Data as T;
        }

        public void ClearData()
        {
            Data = null;
        }
    }
}
