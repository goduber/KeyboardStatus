namespace KeyboardStatus
{
    partial class frmKeyboardStatus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyboardStatus));
            notifyKeyboardStatus = new NotifyIcon(components);
            timerBaterry = new System.Windows.Forms.Timer(components);
            timerCapsLock = new System.Windows.Forms.Timer(components);
            contextMenuStripKeyboardStatus = new ContextMenuStrip(components);
            toolStripMenuItemBattery = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemSalir = new ToolStripMenuItem();
            toolStripMenuItemNumber = new ToolStripMenuItem();
            toolStripMenuItemSL = new ToolStripMenuItem();
            contextMenuStripKeyboardStatus.SuspendLayout();
            SuspendLayout();
            // 
            // notifyKeyboardStatus
            // 
            notifyKeyboardStatus.Text = "notifyIcon1";
            notifyKeyboardStatus.Visible = true;
            // 
            // timerBaterry
            // 
            timerBaterry.Enabled = true;
            timerBaterry.Interval = 6000;
            timerBaterry.Tick += timerBaterry_Tick;
            // 
            // timerCapsLock
            // 
            timerCapsLock.Enabled = true;
            timerCapsLock.Tick += timerCapsLock_Tick;
            // 
            // contextMenuStripKeyboardStatus
            // 
            contextMenuStripKeyboardStatus.Items.AddRange(new ToolStripItem[] { toolStripMenuItemBattery, toolStripMenuItemNumber, toolStripMenuItemSL, toolStripSeparator1, toolStripMenuItemSalir });
            contextMenuStripKeyboardStatus.Name = "contextMenuStripKeyboardStatus";
            contextMenuStripKeyboardStatus.Size = new Size(181, 120);
            // 
            // toolStripMenuItemBattery
            // 
            toolStripMenuItemBattery.Name = "toolStripMenuItemBattery";
            toolStripMenuItemBattery.Size = new Size(180, 22);
            toolStripMenuItemBattery.Text = "item1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // toolStripMenuItemSalir
            // 
            toolStripMenuItemSalir.Image = Properties.Resources.salida_de_emergencia;
            toolStripMenuItemSalir.Name = "toolStripMenuItemSalir";
            toolStripMenuItemSalir.Size = new Size(180, 22);
            toolStripMenuItemSalir.Text = "Salir";
            toolStripMenuItemSalir.Click += toolStripMenuItemSalir_Click;
            // 
            // toolStripMenuItemNumber
            // 
            toolStripMenuItemNumber.Name = "toolStripMenuItemNumber";
            toolStripMenuItemNumber.Size = new Size(180, 22);
            toolStripMenuItemNumber.Text = "item2";
            // 
            // toolStripMenuItemSL
            // 
            toolStripMenuItemSL.Name = "toolStripMenuItemSL";
            toolStripMenuItemSL.Size = new Size(180, 22);
            toolStripMenuItemSL.Text = "item3";
            // 
            // frmKeyboardStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKeyboardStatus";
            Text = "Keyboard Status";
            WindowState = FormWindowState.Minimized;
            Load += frmKeyboardStatus_Load;
            contextMenuStripKeyboardStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyKeyboardStatus;
        private System.Windows.Forms.Timer timerBaterry;
        private System.Windows.Forms.Timer timerCapsLock;
        private ContextMenuStrip contextMenuStripKeyboardStatus;
        private ToolStripMenuItem toolStripMenuItemBattery;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemSalir;
        private ToolStripMenuItem toolStripMenuItemNumber;
        private ToolStripMenuItem toolStripMenuItemSL;
    }
}
