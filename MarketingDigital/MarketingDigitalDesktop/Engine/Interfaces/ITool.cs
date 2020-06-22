﻿using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingDigitalDesktop.Engine.Interfaces
{
    public interface ITool
    {
        DataTable SetTableFolder(SBRecoverFolder listFolders);
        DataGridView ColorFila(DataGridView dgv, Color a, Color b);
        DataTable SetTableRemitente(SBRecoverSender listRemitentes);
        DataTable SetTableContactos(SBResponseContactInList contactList);
        DataTable SetTableListInFolder(SBRecoverListInFolder listFolders);
    }
}
