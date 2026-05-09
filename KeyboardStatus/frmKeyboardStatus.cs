
namespace KeyboardStatus
{
    public partial class frmKeyboardStatus : Form
    {
        private bool capsLockStatus = Control.IsKeyLocked(Keys.CapsLock);
        private Icon iconCapsLockOn = ConverPNGtoICO.MConverPNGtoICO(Properties.Resources.CandLock_A12);
        private Icon iconCapsLockOff = ConverPNGtoICO.MConverPNGtoICO(Properties.Resources.CandLock_A22);

        public frmKeyboardStatus()
        {
            InitializeComponent();
            notifyKeyboardStatus.Icon = capsLockStatus ? iconCapsLockOn : iconCapsLockOff;
            notifyKeyboardStatus.ContextMenuStrip = contextMenuStripKeyboardStatus;
            notifyKeyboardStatus.Text = $"Keyboard Status System - Caps Lock {(capsLockStatus ? "ON" : "OFF")}";
            notifyKeyboardStatus.Visible = true;
        }

        private void frmKeyboardStatus_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void timerBaterry_Tick(object sender, EventArgs e)
        {
            BatteryStatus batteryStatus = new BatteryStatus();

            toolStripMenuItemBattery.Text = $"Nivel de la Batería: {batteryStatus.LevelBaterry()}% - {(batteryStatus.ChargingStatus() ? "Cargando" : "Sin Cargar")}";

            if (batteryStatus.LevelBaterry() == 100 && batteryStatus.ChargingStatus() == true)
                notifyKeyboardStatus.ShowBalloonTip(2000, "Battery Status System", "Carga Completa, desconectar fuente de poder", ToolTipIcon.Info);
            if (batteryStatus.LevelBaterry() <= 10 && batteryStatus.ChargingStatus() == false)
                notifyKeyboardStatus.ShowBalloonTip(2000, "Battery Status System", "Carga al 10% o menos, conectar fuente de poder", ToolTipIcon.Warning);
        }

        private void timerCapsLock_Tick(object sender, EventArgs e)
        {
            bool currentCapsLockStatus = Control.IsKeyLocked(Keys.CapsLock);
            if(capsLockStatus != currentCapsLockStatus)
            {
                capsLockStatus = currentCapsLockStatus;
                notifyKeyboardStatus.Icon = capsLockStatus ? iconCapsLockOn : iconCapsLockOff;
                notifyKeyboardStatus.Text = $"Keyboard Status System - Caps Lock {(capsLockStatus ? "ON" : "OFF")}";
            }

            toolStripMenuItemNumber.Text = $"Num Lock: {(Control.IsKeyLocked(Keys.NumLock) ? "ON" : "OFF")}";
            toolStripMenuItemSL.Text = $"Scroll Lock: {(Control.IsKeyLocked(Keys.Scroll) ? "ON" : "OFF")}";
        }

        private void toolStripMenuItemSalir_Click(object sender, EventArgs e)
        {
            timerBaterry.Stop();
            timerCapsLock.Stop();
            iconCapsLockOff?.Dispose();
            iconCapsLockOn?.Dispose();
            this.Dispose();
            Application.Exit();
        }
    }
}
