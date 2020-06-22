using MarketingDigitalBCS.Response;
using MarketingDigitalDesktop.Engine.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingDigitalDesktop.Engine
{
    public class Tool : ITool
    {
        public DataTable SetTableRemitente(SBRecoverSender listRemitentes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("EMAIL");
            dt.Columns.Add("ESTADO");
            var status = string.Empty;
            foreach (var item in listRemitentes.senders)
            {
                if (item.active)
                    status = "ACTIVO";
                else
                    status = "INACTIVO";

                dt.Rows.Add(item.id, item.name, item.email,status);
            }
            return dt;
        }

        public DataTable SetTableFolder(SBRecoverFolder listFolders)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CARPETA");
            dt.Columns.Add("SUBCRISTORES");


            foreach (var item in listFolders.folders)
            {
                dt.Rows.Add(item.id, item.name, item.uniqueSubscribers);
            }
            return dt;
        }

        public DataTable SetTableListInFolder(SBRecoverListInFolder listFolders)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("LISTA");
            dt.Columns.Add("SUBCRISTORES");


            foreach (var item in listFolders.lists)
            {
                dt.Rows.Add(item.id, item.name, item.totalSubscribers);
            }
            return dt;
        }

        public DataGridView ColorFila(DataGridView dgv, Color a, Color b)
        {
            int n = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (n % 2 == 0)
                    row.DefaultCellStyle.BackColor = a;
                else
                    row.DefaultCellStyle.BackColor = b;
                n++;
            }
            return dgv;
        }

        public DataTable SetTableContactos(SBResponseContactInList contactList)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("APELLIDO");
            dt.Columns.Add("EMAIL");
            dt.Columns.Add("TELEFONO");

            foreach (var item in contactList.contacts)
            {
                dt.Rows.Add(item.id,  item.attributes.NOMBRE,item.attributes.SURNAME , item.email, item.attributes.SMS);
            }
            return dt;
        }
    }
}
