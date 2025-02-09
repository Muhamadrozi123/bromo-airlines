﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bromo_airlines
{
    public partial class UbahStatusPenerbangan : Form
    {
        public UbahStatusPenerbangan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UbahStatusPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("IP-7869", "Airlion Ai", "Soekarno-Hatta", "Supadio", "21-04-2023", "07:25", "01 jam 3", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("IU-0697", "Super Ai", "Supadio", "Soekarno-Hatta", "27-04-2023", "09:40", "01 jam 2", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("ID-7508", "Batik Air", "Juanda", "Halim P", "22-05-2023", "05:00", "01 jam 1", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("ID-6589", "Batik Air", "Juanda", "Soekarno-Hatta", "22-05-2023", "05:00", "01 jam 2", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("JT-0786", "Lion Air", "Juanda", "Soekarno-Hatta", "22-05-2023", "05:00", "01 jam 3", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("JT-0646", "Lion Air", "Juanda", "Soekarno-Hatta", "22-05-2023", "05:55", "01 jam 0", "Sesuai Jadwal", "-","Ubah", "Simpan");
            dataGridView1.Rows.Add("QG-0725", "Citilink", "Juanda", "Soekarno-Hatta", "22-05-2023", "06:00", "01 jam 3", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("IU-0706", "Super Ai", "Juandaa", "Soekarno-Hatta", "22-05-2023", "06:00", "00 jam ", "Sesuai Jadwal", "-", "Ubah", "Simpan");
            dataGridView1.Rows.Add("IU-0333", "Super Ai", "Juanda", "Soekarno-Hatta", "22-05-2023", "06:00", "01 jam 2", "Sesuai Jadwal", "-","Ubah", "Simpan");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DaftarAkunForm form = new DaftarAkunForm();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterBandaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterKodePromo form = new MasterKodePromo();
            form.ShowDialog();
        }

        private void ubahStatusPenerbanganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void masterBandaraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void masterMaskapaiToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            MasterMaskapai form = new MasterMaskapai();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked_4(object sender, ToolStripItemClickedEventArgs e)
        {
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
            form.ShowDialog();
        }

        private void masterBandaraToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            MasterBandara form = new MasterBandara();
            form.ShowDialog();
        }

        private void maskerMaskapaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterMaskapaiValid mask = new MasterMaskapaiValid();
            mask.ShowDialog();
        }

        private void masterJadwalPenerbanganToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasterJadwalPenerbangan form = new MasterJadwalPenerbangan();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MasterKodePromo form = new MasterKodePromo();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void ubahStatusPENEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
