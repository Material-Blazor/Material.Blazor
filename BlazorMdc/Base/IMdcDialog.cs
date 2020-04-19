using System;
using System.Collections.Generic;

namespace BlazorMdc
{
    public interface IMdcDialog
    {
        void RegisterLayoutAction(IMdcDialogChild child);
    }
}
