using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace SignalRComDotNetFramework
{
    public class MoveShapeHub : Hub
    {
        public void UpdateModel(ShapeModel clientModel)
        {
            clientModel.LastUpdateBy = Context.ConnectionId;
            Clients.AllExcept(clientModel.LastUpdateBy).updateShape(clientModel);
        }

        //public void UpdateModel(TextModel textModel)
        //{
        //    textModel.LastUpdateBy = Context.ConnectionId;
        //    Clients.AllExcept(textModel.LastUpdateBy).updateShape(textModel);
        //}

        public class ShapeModel
        {
            [JsonProperty("left")]
            public double Left { get; set; }
            [JsonProperty("top")]
            public double Top { get; set; }
            public string LastUpdateBy { get; set; }
        }

        public class TextModel
        {
            
            [JsonProperty("ptext")]
            public string Text { get; set; }
            public string LastUpdateBy { get; set; }
        }

    }
}