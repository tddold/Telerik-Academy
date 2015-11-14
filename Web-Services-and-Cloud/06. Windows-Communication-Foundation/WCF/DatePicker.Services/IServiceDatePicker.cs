namespace DatePicker.Services
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IServiceDatePicker
    {
        [OperationContract]
        string GetDayOfWeek(DateTime date);
    }
}
