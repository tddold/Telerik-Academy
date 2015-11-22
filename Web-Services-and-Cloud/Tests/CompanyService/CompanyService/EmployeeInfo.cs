namespace WcfCompanyService
{
    using System.Runtime.Serialization;

    [DataContract]
    public class EmployeeInfo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Department { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}