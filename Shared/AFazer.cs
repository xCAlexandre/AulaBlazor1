using System;
namespace aulablazor1.Shared
{
    public class AFazer
    {
        public string titulo { get; set; }

        public bool feito { get; set; }
        public DateTime data;

        public DateTime GetData(){
            return data;
        }

        public void SetData(){
            data = DateTime.Now;
        }

    }
}