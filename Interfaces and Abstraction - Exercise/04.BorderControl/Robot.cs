using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Model { get; }
        public string Id { get; }
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}