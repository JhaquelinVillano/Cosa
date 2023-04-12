﻿using Proyecto.Biblioteca;
using Proyecto.Donadores;
using Proyecto.Entradas_y_Salidas;
using Proyecto.Inventario;
using Proyecto.Restauración;
using Proyecto.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Windows.Media;
using Proyecto.Empleados;
using Proyecto.Clientes;
using MySql.Data.MySqlClient;
using Proyecto.Maestros;
using Proyecto.Centro_de_Atención;

namespace Proyecto.Menu
{
    public partial class frmMenu : Form
    {
        private IconButton currentBtn;
        public string Usuario;
        public string biblioteca;
        public string inventario;
        public string id_tipo;
        private Form currentChildForm;

        public frmMenu()
        {
            InitializeComponent();
            customizeDesing();
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Colores de los botones
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Cambia la imagen de la barra superior conforme el formulario abierto en el menu
                picHijoActual.IconChar = currentBtn.IconChar;
                lblTituloFormHijo.Text = " ";
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.SlateBlue;
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Aqui se ocultan los paneles de submenu
        private void customizeDesing()
        {
            pnlSubBiblioteca.Visible = false;
            pnlSubInventario.Visible = false;
            pnlSubPersonal.Visible = false;
            pnlSubMaestros.Visible = false;
            pnlSubCentroAtencion.Visible = false;
        }

        //esconder el submenu
        private void hideSubMenu()
        {
            if (pnlSubBiblioteca.Visible == true)
                pnlSubBiblioteca.Visible = false;
            if (pnlSubInventario.Visible == true)
                pnlSubInventario.Visible = false;
            if (pnlSubPersonal.Visible == true)
                pnlSubPersonal.Visible = false;
            if (pnlSubMaestros.Visible == true)
                pnlSubMaestros.Visible = false;
            if (pnlSubCentroAtencion.Visible == true)
                pnlSubCentroAtencion.Visible = false;

        }

        //mostrar submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false) 
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void picBarra_Click(object sender, EventArgs e)
        {
            if (pnlMenuVertical.Width == 250)
            {
                pnlMenuVertical.Width = 0;
            }
            else
            {
                pnlMenuVertical.Width = 250;
            }
            
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        //Mover el formulario-----------------------------------
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwmd, int wnsg, int wparam, int lparam);

        //---------------------------------------
        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlSubBiblioteca);
        }

        private void btnLibros_Click_1(object sender, EventArgs e)
        {
            frmLibros Libros = new frmLibros();
            Libros.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmLibros());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos PD = new frmPrestamos();
            PD.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmPrestamos());
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            frmDevoluciones devoluciones = new frmDevoluciones();
            devoluciones.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmDevoluciones());
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlSubPersonal);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {    
            Empleados.frmEmpleados empleados = new Empleados.frmEmpleados();
            empleados.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmEmpleados()); 
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuarios = new frmUsuarios();
            Usuarios.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmUsuarios());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Clientes.frmClientes clientes = new Clientes.frmClientes();
            clientes.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmClientes());
        }

        private void btnDonadores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            frmDonadores Donadores = new frmDonadores();
            Donadores.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmDonadores());
        }
        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlSubInventario);
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            frmEntradas entradas = new frmEntradas();
            entradas.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmEntradas());
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            frmSalidas salidas = new frmSalidas();
            salidas.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmSalidas());
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Inventario.frmInventario inventarios = new frmInventario();
            inventarios.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmInventario()); 
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            this.Close();
            frmLogin Login = new frmLogin();
            Login.Show();
            hideSubMenu();
            

        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            picHijoActual.IconChar = IconChar.Home;
            lblTituloFormHijo.Text = "Inicio";

        }
        
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(childForm);
            pnlControl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloFormHijo.Text = childForm.Text;
                
                
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (id_tipo == "Encargado")
            {
                btnPersonal.Enabled = false;
                btnPersonal.Visible = false;
                btnRestauracion.Enabled = false;
                btnRestauracion.Visible = false;
            }
            if (biblioteca == "NO")
            {
                btnBiblioteca.Enabled = false;
                btnBiblioteca.Visible = false;
                btnClientes.Enabled = false;
                btnClientes.Visible = false;
            }
            if (inventario == "NO")
            {
                btnInventario.Enabled = false;
                btnInventario.Visible = false;
                btnDonadores.Enabled = false;
                btnDonadores.Visible = false;
            }
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlSubMaestros);
        }

        private void btnCentroAtencion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showSubMenu(pnlSubCentroAtencion);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            //alumnos.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmAlumnos());
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            frmIncidencias incidencias = new frmIncidencias();
            //incidencias.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmIncidencias());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frmReporteSemanal reporteSemanal = new frmReporteSemanal();
            //reporteSemanal.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmReporteSemanal());
        }

        private void btnAsistenciaFamiliar_Click(object sender, EventArgs e)
        {
            frmAsistenciaFamiliar asistenciaFamiliar = new frmAsistenciaFamiliar();
            //asistenciaFamiliar.Usuario = Usuario;
            hideSubMenu();
            openChildForm(new frmAsistenciaFamiliar());
        }

        private void btnRestauracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            frmRestauracion Restauracion = new frmRestauracion();
            Restauracion.Usuario = Usuario;
            hideSubMenu();
            this.Close();
            Restauracion.Show();
            //openChildForm(new frmRestauracion());
        }

        private void picMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      //private void picMaximizar_Click(object sender, EventArgs e)
     // {
    //     if (WindowState == FormWindowState.Normal)
    //         WindowState = FormWindowState.Maximized;
    //     else
    //         WindowState = FormWindowState.Normal;
     // }
    }
}
