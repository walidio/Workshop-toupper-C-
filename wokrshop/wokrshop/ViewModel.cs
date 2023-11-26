using System;
using System.Collections.Generic;
using System.Text;

namespace wokrshop
{
    class ViewModel
    {
        public Model model = new Model();
        public View view = new View();
        public void Conversion()
        {
            string Input = view.ReadInput();
            string ToUpper = model.toupper(Input);
            view.PrintOutput(ToUpper);
        }
    }
}
