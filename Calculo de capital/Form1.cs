using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculo_de_capital
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Collections.ArrayList Lista;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGrid dataGridPedidos;
		private System.Windows.Forms.TextBox TMontoInicial;
		private System.Windows.Forms.TextBox TTasaInteres;
		private System.Windows.Forms.TextBox TAbono;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TCapitalPagado;
		private System.Windows.Forms.TextBox TInteresPagado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TTotal;
		private System.Windows.Forms.Label LPeligro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label LMeses;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label LAños;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.TMontoInicial = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TTasaInteres = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TAbono = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridPedidos = new System.Windows.Forms.DataGrid();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TCapitalPagado = new System.Windows.Forms.TextBox();
			this.TInteresPagado = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TTotal = new System.Windows.Forms.TextBox();
			this.LPeligro = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.LMeses = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.LAños = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.LAños);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.LMeses);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.LPeligro);
			this.panel1.Controls.Add(this.TTotal);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.TInteresPagado);
			this.panel1.Controls.Add(this.TCapitalPagado);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.TAbono);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.TTasaInteres);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.TMontoInicial);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(704, 136);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Monto inicial";
			// 
			// TMontoInicial
			// 
			this.TMontoInicial.Location = new System.Drawing.Point(88, 8);
			this.TMontoInicial.Name = "TMontoInicial";
			this.TMontoInicial.TabIndex = 1;
			this.TMontoInicial.Text = "50000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tasa de interes";
			// 
			// TTasaInteres
			// 
			this.TTasaInteres.Location = new System.Drawing.Point(96, 40);
			this.TTasaInteres.Name = "TTasaInteres";
			this.TTasaInteres.TabIndex = 3;
			this.TTasaInteres.Text = "1.2221";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Abono";
			// 
			// TAbono
			// 
			this.TAbono.Location = new System.Drawing.Point(56, 72);
			this.TAbono.Name = "TAbono";
			this.TAbono.TabIndex = 5;
			this.TAbono.Text = "1039.2";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 6;
			this.button1.Text = "Calcular";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridPedidos
			// 
			this.dataGridPedidos.DataMember = "";
			this.dataGridPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridPedidos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridPedidos.Location = new System.Drawing.Point(0, 136);
			this.dataGridPedidos.Name = "dataGridPedidos";
			this.dataGridPedidos.ReadOnly = true;
			this.dataGridPedidos.Size = new System.Drawing.Size(704, 301);
			this.dataGridPedidos.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(336, 16);
			this.label4.Name = "label4";
			this.label4.TabIndex = 7;
			this.label4.Text = "Capital pagado";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(336, 48);
			this.label5.Name = "label5";
			this.label5.TabIndex = 8;
			this.label5.Text = "Interes pagado";
			// 
			// TCapitalPagado
			// 
			this.TCapitalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TCapitalPagado.Location = new System.Drawing.Point(432, 16);
			this.TCapitalPagado.Name = "TCapitalPagado";
			this.TCapitalPagado.TabIndex = 9;
			this.TCapitalPagado.Text = "0";
			// 
			// TInteresPagado
			// 
			this.TInteresPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TInteresPagado.Location = new System.Drawing.Point(432, 48);
			this.TInteresPagado.Name = "TInteresPagado";
			this.TInteresPagado.TabIndex = 10;
			this.TInteresPagado.Text = "0";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(336, 80);
			this.label6.Name = "label6";
			this.label6.TabIndex = 11;
			this.label6.Text = "Total";
			// 
			// TTotal
			// 
			this.TTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TTotal.Location = new System.Drawing.Point(432, 80);
			this.TTotal.Name = "TTotal";
			this.TTotal.TabIndex = 12;
			this.TTotal.Text = "0";
			// 
			// LPeligro
			// 
			this.LPeligro.AutoSize = true;
			this.LPeligro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.LPeligro.ForeColor = System.Drawing.Color.Red;
			this.LPeligro.Location = new System.Drawing.Point(568, 48);
			this.LPeligro.Name = "LPeligro";
			this.LPeligro.Size = new System.Drawing.Size(133, 34);
			this.LPeligro.TabIndex = 13;
			this.LPeligro.Text = "PELIGRO";
			this.LPeligro.Visible = false;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 96);
			this.label7.Name = "label7";
			this.label7.TabIndex = 14;
			this.label7.Text = "meses";
			// 
			// LMeses
			// 
			this.LMeses.Location = new System.Drawing.Point(64, 104);
			this.LMeses.Name = "LMeses";
			this.LMeses.TabIndex = 15;
			this.LMeses.Text = "label8";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(184, 104);
			this.label8.Name = "label8";
			this.label8.TabIndex = 16;
			this.label8.Text = "Años";
			// 
			// LAños
			// 
			this.LAños.Location = new System.Drawing.Point(232, 104);
			this.LAños.Name = "LAños";
			this.LAños.TabIndex = 17;
			this.LAños.Text = "label9";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 437);
			this.Controls.Add(this.dataGridPedidos);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			LPeligro.Visible=false;
			Lista=new ArrayList();
			CCalculo calculo=new CCalculo();
			calculo.AmortCapital=0;
			calculo.AmotIntereces=0;
			calculo.Abono=float.Parse(this.TAbono.Text);
			calculo.MontoInicial=float.Parse(this.TMontoInicial.Text);
			float interes=float.Parse(this.TTasaInteres.Text);
			float Capital=calculo.MontoInicial;
			float doble=Capital*2;
			//hago el calculo
			Lista.Add(calculo);
			float interespagado=0;
			float CapitalPagado=0;

			while(Capital>0)
			{
				CCalculo calculo2=new CCalculo();
				//hago el canculo de la amortizacion de interes
				calculo2.AmotIntereces=Capital*interes/100;
				//obtengo el abono
				float abono=float.Parse(this.TAbono.Text);
				if(Capital<abono)
					calculo2.Abono=Capital;
				else
					calculo2.Abono=abono;
				//hago el calculo de la amortizacion de capital
				calculo2.AmortCapital=calculo2.Abono-calculo2.AmotIntereces;
				//hago el calculo del nuevo monto
				if(Capital<abono)
					Capital=Capital-Capital;
				else
				Capital=Capital-calculo2.AmortCapital;
				calculo2.MontoInicial=Capital;
				interespagado=interespagado+calculo2.AmotIntereces;
				CapitalPagado=CapitalPagado+calculo2.AmortCapital;
				Lista.Add(calculo2);
				if(doble<Capital)
				{
					LPeligro.Visible=true;
					break;
				}
			}
			//muestro los calculos
			MuestraCalculos();
			this.TCapitalPagado.Text=CapitalPagado.ToString();
			this.TInteresPagado.Text=interespagado.ToString();
			float total=CapitalPagado+interespagado;
			TTotal.Text=total.ToString();
			LMeses.Text=(Lista.Count/2).ToString();
			LAños.Text=(float.Parse(LMeses.Text)/12).ToString();
		}
		private void MuestraCalculos()
		{
//			Pedidos=DB.DameListaPedidos(estado);
			DataSet ds = new DataSet();
			DataTable dt = new DataTable("Article");			
			//Create two columns, and add them to the first table.
			DataColumn dcNum= new DataColumn("NUM"); 
			DataColumn dcMontoIncial= new DataColumn("MONTO INICIAL"); 
			DataColumn dcAbono= new DataColumn("ABONO"); 
			DataColumn dcAmortCapital= new DataColumn("AMORTIZACION DE CAPITAL"); 
			DataColumn dcAmortInteres= new DataColumn("AMORTIZACION DE INTERES"); 
			//assign the datacolum into datatable
			dt.Columns.Add(dcNum);
			dt.Columns.Add(dcMontoIncial);
			dt.Columns.Add(dcAbono);
			dt.Columns.Add(dcAmortCapital);
			dt.Columns.Add(dcAmortInteres);
			//Add the table to the DataSet.
			ds.Tables.Add(dt);
			int i,n;
			n=Lista.Count;
			for(i=0;i< n;i++)
			{
				DataRow drRow = dt.NewRow();
				CCalculo c= (CCalculo)Lista[i];
				drRow["NUM"]=i.ToString();
				drRow["MONTO INICIAL"]=c.MontoInicial;
				drRow["ABONO"]=c.Abono;
				drRow["AMORTIZACION DE CAPITAL"]=c.AmortCapital;
				drRow["AMORTIZACION DE INTERES"]=c.AmotIntereces;
				dt.Rows.Add(drRow);
			}
			
			dataGridPedidos.DataSource = ds.Tables[0];
			DataGridTableStyle ts = new DataGridTableStyle();			
			ts.MappingName = "Article";

			//----------------------------------------------------------
			DataGridColumnStyle  NUM= new DataGridTextBoxColumn();
			NUM.MappingName = "NUM";
			NUM.HeaderText = "NUM";
			NUM.Width=100;
			ts.GridColumnStyles.Add(NUM);
			//----------------------------------------------------------
			DataGridColumnStyle  MONTOINICIAL= new DataGridTextBoxColumn();
			MONTOINICIAL.MappingName = "MONTO INICIAL";
			MONTOINICIAL.HeaderText = "MONTO INICIAL";
			MONTOINICIAL.Width=100;
			ts.GridColumnStyles.Add(MONTOINICIAL);
			//----------------------------------------------------------
			DataGridColumnStyle  ABONO= new DataGridTextBoxColumn();
			ABONO.MappingName = "ABONO";
			ABONO.HeaderText = "ABONO";
			ABONO.Width=100;
			ts.GridColumnStyles.Add(ABONO);
			//----------------------------------------------------------
			DataGridColumnStyle  AMORTIZACION_CAPITAL= new DataGridTextBoxColumn();
			AMORTIZACION_CAPITAL.MappingName = "AMORTIZACION DE CAPITAL";
			AMORTIZACION_CAPITAL.HeaderText = "AMORTIZACION DE CAPITAL";
			AMORTIZACION_CAPITAL.Width=300;
			ts.GridColumnStyles.Add(AMORTIZACION_CAPITAL);
			//----------------------------------------------------------
			DataGridColumnStyle  AMORTIZACION_INTERES= new DataGridTextBoxColumn();
			AMORTIZACION_INTERES.MappingName = "AMORTIZACION DE INTERES";
			AMORTIZACION_INTERES.HeaderText = "AMORTIZACION DE INTERES";
			AMORTIZACION_INTERES.Width=300;
			ts.GridColumnStyles.Add(AMORTIZACION_INTERES);
			//----------------------------------------------------------
			ts.MappingName = "Article";
			dataGridPedidos.TableStyles.Clear();
			dataGridPedidos.TableStyles.Add(ts);
			
		}
	}
}
