﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddPedido : Form
    {
        private bool consultar;
        public List<Cliente> clientes { get; set; }
        public List<Trabalhador> trabalhadores{ get; set; }
        public List<ItemMenu> todosItensMenu { get; set; }
        public Cliente cliente { get; set; }
        public Trabalhador trabalhador { get; set; }
        public int trabalhadorID { get; set; }
        public Estado estado { get; set; }
        public List<ItemMenu> itensMenu { get; set; }
        public Restaurante restaurante;
        public FormAddPedido(List<Cliente> clientes = null, List<Trabalhador> trabalhadores = null, List<ItemMenu> todosItensMenu = null, List<ItemMenu> itensMenu = null, Estado estado = null, bool consultar = false, Cliente cliente = null, Trabalhador trabalhador = null)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.clientes = clientes;
            this.trabalhadores = trabalhadores;
            this.todosItensMenu = todosItensMenu;
            this.trabalhador = trabalhador;
            this.itensMenu = itensMenu;
            this.estado = estado;
            this.consultar = consultar;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //adicionar o item selecionado ao menu
            ItemMenu itemSelecionado = listBoxItensRestaurante.SelectedItem as ItemMenu;
         
            if(itemSelecionado == null)
            {
                MessageBox.Show("Tem de selecionar um item do restaurante!");
                return;
            }
            foreach(ItemMenu item in itensMenu)
            {
                if(itemSelecionado == item)
                {
                    MessageBox.Show("Item já existe no menu!");
                    return;
                }
            }
            itensMenu.Add(itemSelecionado);
            LerDados();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            //remove o item selecionado do pedido
            ItemMenu itemSelecionado = listBoxPedido.SelectedItem as ItemMenu;
            if (itemSelecionado == null)
            {
                MessageBox.Show("Tem de selecionar um item do pedido!");
                return;
            }
            itensMenu.Remove(itemSelecionado);
            LerDados();
        }

        private void FormAddPedido_Load(object sender, EventArgs e)
        {
            if (consultar)
            {
                buttonAdicionar.Enabled = false;
                buttonRemover.Enabled = false;
                buttonGuardar.Enabled = false;
                comboBoxCliente.Enabled = false;
                comboBoxTrabalhador.Enabled = false;
            }
            LerDados();
            comboBoxCliente.DataSource = clientes;
            comboBoxTrabalhador.DataSource = trabalhadores;
            listBoxItensRestaurante.DataSource = todosItensMenu;

            if(estado != null)
            {
                labelEstadoPedido.Text = estado.EstadoAtual;
            }
            if(cliente != null)
            {
                comboBoxCliente.SelectedItem = cliente;
            }
            if(trabalhador != null)
            {
                comboBoxTrabalhador.SelectedItem = trabalhador;
            }
        }
        private void LerDados()
        {
            listBoxPedido.DataSource = itensMenu.ToList();
            decimal valorTotal = 0;
            foreach(ItemMenu list in itensMenu)
            {
                valorTotal += list.Preco;
            }
            labelTotalPedido.Text = valorTotal + "€";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.trabalhador = comboBoxTrabalhador.SelectedItem as Trabalhador;
            this.cliente = comboBoxCliente.SelectedItem as Cliente;
            if(cliente == null)
            {
                MessageBox.Show("Tem de selecionar um cliente!");
                return;
            }
            if (trabalhador == null)
            {
                MessageBox.Show("Tem de selecionar um trabalhador!");
                return;
            }
           
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Pedido criado com sucesso!");
            this.Close();
        }

    }
}
