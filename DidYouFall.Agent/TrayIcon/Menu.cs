﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DidYouFall.Agent.Forms;
using DidYouFall.Agent.Info;

namespace DidYouFall.Agent.TrayIcon
{
    class Menu
    {
        bool isAboutLoaded = false;
        bool isStatusLoaded = false;
        bool isConfigLoaded = false;

        public ContextMenuStrip Create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;
            ToolStripSeparator separator;


            // Configurar
            item = new ToolStripMenuItem();
            item.Text = "Config";
            item.Click += new EventHandler(Config_Click);
            menu.Items.Add(item);


            // Verificar
            item = new ToolStripMenuItem();
            item.Text = "Status";
            item.Click += new EventHandler(Status_Click);
            menu.Items.Add(item);

            // Sobre.
            item = new ToolStripMenuItem();
            item.Text = "Sobre";
            item.Click += new EventHandler(About_Click);
            menu.Items.Add(item);
            

            // Separador.
            separator = new ToolStripSeparator();
            menu.Items.Add(separator);

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Fechar";
            item.Click += new EventHandler(Exit_Click);
            menu.Items.Add(item);

            return menu;

        }

        void Config_Click(object sender, EventArgs e)
        {
            if (!isConfigLoaded)
            {
                isConfigLoaded = true;
                new Forms.Configuration(Program.PcInfo).ShowDialog();
                isConfigLoaded = false;
            }
        }


        void About_Click(object sender, EventArgs e)
        {
            if (!isAboutLoaded)
            {
                isAboutLoaded = true;
                new About().ShowDialog();
                isAboutLoaded = false;
            }
        }
        void Status_Click(object sender, EventArgs e)
        {
            if (!isStatusLoaded)
            {
                isStatusLoaded = true;
                new Status(new PC()).ShowDialog();
                isStatusLoaded = false;
            }
        }
        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

