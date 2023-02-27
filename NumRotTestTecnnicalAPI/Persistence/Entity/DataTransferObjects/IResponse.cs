namespace NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects {


    public interface IResponse {
        bool status { get; set; }
        string message { get; set; }
    }

    public interface IResponse<T> : IResponse {
        T? data { get; set; }
    }

}
