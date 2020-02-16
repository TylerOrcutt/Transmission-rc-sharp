using System;
using Gdk;
using Gtk;

namespace Transmission_rc_sharp
{
    class Program
    {
        public static StatusIcon statusIcon;
        static void Main(string[] args)
        {
            Application.Init();
            Gtk.Window win = new Gtk.Window("test");
            win.Icon = new Pixbuf("images/icon.png");


            statusIcon = new StatusIcon(new Pixbuf("images/icon.png"));
            statusIcon.PopupMenu += OnTrayIcon;

            win.TypeHint = WindowTypeHint.Dialog;
            win.SetSizeRequest(800, 500);

            Box box = new Box(Orientation.Vertical, 5);
            box.Show();
            win.Add(box);

            Toolbar tb = new Toolbar();
            box.Add(tb);
            tb.Show();

            ToolButton tbStop = new ToolButton(Stock.MediaPause);
            tb.Insert(tbStop, 0);


            ListBox listbx = new ListBox();
            Label lbltest = new Label("test");
            lbltest.Show();
            listbx.Add(lbltest);
            listbx.Add(new Label("Test2"));
            box.Add(listbx);
            listbx.ShowAll();


            win.ShowAll();
            win.KeepAbove = true;


            Application.Run();
        }

        public static void OnTrayIcon(object sender,EventArgs e)
        {
            Menu menu = new Menu();
            MenuItem item = new MenuItem("test");
            //menu.Add(item);
            menu.ShowAll();
            menu.Popup();

        }
    }
}
