using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCobroFacturacion;
using SistemaCobroFacturacion.Vista;

namespace SistemaCobroFacturacion.Vista
{
    public partial class Principal : Form
    {
        private Bar bar;

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bar = new Bar();
            this.bar.MdiParent = this;
            this.bar.Show();
        }

        private void reingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        /*private GestionarContactos addContacto;
private GestionarUsuario addUser;
private AcercaDe mosacercaDe;

public Principal()
{
InitializeComponent();
}

public Principal(Usuario usuarito)
{
InitializeComponent();
this.StatusUsuario.Text = "Bienvenid@ " + usuarito.Nombre;
validarPerfil(usuarito.Perfil);
}

private void validarPerfil(string perfil)
{
switch(perfil)
{
case "P1":
  this.contactosToolStripMenuItem.Enabled = false;
  break;
case "P2":
  this.usuariosToolStripMenuItem.Visible = false;
  break;
}
}

private void gestionarContactosToolStripMenuItem_Click(object sender, EventArgs e)
{
this.addContacto = new GestionarContactos();// inicializo el atributo de mi ventana hija q habia creado
this.addContacto.MdiParent = this; // con esto le digo a la hija su papa va ser esta ventana con el this
this.addContacto.Show(); // con esto le digo que se muestre
}

private void salirToolStripMenuItem_Click(object sender, EventArgs e)
{
this.addContacto = null;
this.addUser = null;
this.mosacercaDe = null;

Application.Exit();
}

private void reingresarToolStripMenuItem_Click(object sender, EventArgs e)
{
this.addContacto = null;
this.addUser=null;
this.mosacercaDe = null;
Application.Restart();
}

private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
{
this.addUser = new GestionarUsuario();// inicializo el atributo de mi ventana hija q habia creado
this.addUser.MdiParent = this; // con esto le digo a la hija su papa va ser esta ventana con el this
this.addUser.Show(); // con esto le digo que se muestre
}

private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
{
this.mosacercaDe = new AcercaDe();// inicializo el atributo de mi ventana hija q habia creado
this.mosacercaDe.MdiParent = this; // con esto le digo a la hija su papa va ser esta ventana con el this
this.mosacercaDe.Show(); // con esto le digo que se muestre
}*/
    }
}