using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace KeyboardStatus
{
    internal static class ConverPNGtoICO
    {

        //[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]

        //extern static bool DestroyIcon(IntPtr handle);

        //public static Icon MConverPNGtoICO(Bitmap bitmap)
        //{
        //    IntPtr hIcon = bitmap.GetHicon();
        //    Icon icono = (Icon)Icon.FromHandle(hIcon).Clone(); // Clonamos para que el objeto sea independiente
        //    DestroyIcon(hIcon); // Liberamos el recurso nativo inmediatamente
        //    return icono;
        //}

        // Importamos la función nativa de Windows para destruir iconos
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        public static Icon MConverPNGtoICO(Bitmap bitmapSource)
        {
            IntPtr hIcon = IntPtr.Zero;
            try
            {
                // 1. Creamos el handle nativo
                hIcon = bitmapSource.GetHicon();

                // 2. Creamos el objeto Icon a partir del handle
                // .Clone() es vital porque FromHandle no crea una copia propia
                using (Icon tempIcon = Icon.FromHandle(hIcon))
                {
                    return (Icon)tempIcon.Clone();
                }
            }
            finally
            {
                // 3. LIBERACIÓN CRÍTICA:
                // Destruimos el handle nativo inmediatamente después de clonar.
                // Si no haces esto, la memoria nativa nunca se libera.
                if (hIcon != IntPtr.Zero)
                {
                    DestroyIcon(hIcon);
                }
            }
        }
    }
}
