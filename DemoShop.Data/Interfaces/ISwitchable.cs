using System;
using System.Collections.Generic;
using System.Text;
using DemoShop.Data.Enums;

namespace DemoShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
