using NumRotTestTecnnicalAPI.Persistence.Entity.DataTransferObjects;

namespace NumRotTestTecnnicalAPI.Controllers {
    public class ResponseFactory {
        public static IResponse<T> Crear<T>(bool status, string message, T data) {
            if (status) {
                return new RespuestaExitosa<T> {
                    status = true,
                    message = message,
                    data = data
                };
            } else {
                return new RespuestaFallida<T> {
                    status = false,
                    message = message,
                    data = data
                };
            }
        }

        private class RespuestaExitosa<T> : IResponse<T> {
            public bool status { get; set; }
            public string message { get; set; }
            public T? data { get; set; }
        }

        private class RespuestaFallida<T> : IResponse<T> {
            public bool status { get; set; }
            public string message { get; set; }
            public T? data { get; set; }
        }
    }
}