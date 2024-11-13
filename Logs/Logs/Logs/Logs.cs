using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Logs
{
    public partial class Logs : Form
    {
        private List<EventLogEntry> eventEntries = new List<EventLogEntry>();

        public Logs()
        {
            InitializeComponent();

            // Style général de la fenêtre
            this.Text = "Visualiseur de Journaux";
            this.BackColor = Color.FromArgb(240, 240, 240); // Couleur d'arrière-plan douce

            // Boutons stylisés
            buttonFiltrer.Text = "Filtrer";
            buttonFiltrer.BackColor = Color.SteelBlue;
            buttonFiltrer.ForeColor = Color.White;
            buttonFiltrer.FlatStyle = FlatStyle.Flat;

            buttonSuppr.Text = "Supprimer";
            buttonSuppr.BackColor = Color.DarkOrange;
            buttonSuppr.ForeColor = Color.White;
            buttonSuppr.FlatStyle = FlatStyle.Flat;

            buttonToutSuppr.Text = "Tout Supprimer";
            buttonToutSuppr.BackColor = Color.Crimson;
            buttonToutSuppr.ForeColor = Color.White;
            buttonToutSuppr.FlatStyle = FlatStyle.Flat;

            buttonQuitter.Text = "Quitter";
            buttonQuitter.BackColor = Color.Gray;
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.FlatStyle = FlatStyle.Flat;

            // Bouton Exporter avec style personnalisé
            buttonExporter.Text = "Exporter";
            buttonExporter.BackColor = Color.SeaGreen;
            buttonExporter.ForeColor = Color.White;
            buttonExporter.FlatStyle = FlatStyle.Flat;
            buttonExporter.Click += new EventHandler(buttonExporter_Click); // Attache l'événement pour le clic

            // Initialiser ComboBox avec les types de filtres
            comboBoxFilterType.Items.AddRange(new string[] { "Information", "Warning", "Error", "SuccessAudit", "FailureAudit" });
            comboBoxFilterType.SelectedIndex = 0; // Sélectionne "Information" par défaut

            // Charger les journaux et configurer DataGridView
            MessageBox.Show("Chargement des journaux système en cours...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEventLogs();
            InitializeDataGridView();
        }

        private void LoadEventLogs()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (var log in EventLog.GetEventLogs())
                {
                    try
                    {
                        listBox1.Items.Add(log.Log); // Ajoute le nom du journal à la liste
                    }
                    catch (System.Security.SecurityException)
                    {
                        MessageBox.Show("Accès refusé pour le journal : " + log.LogDisplayName, "Erreur d'accès", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des journaux : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur critique lors du chargement des journaux : " + ex.Message, "Erreur critique", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Initialisation de l'affichage des logs dans DataGridView
        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Niveau", "Niveau");
            dataGridView1.Columns.Add("DateEtHeure", "Date et Heure");
            dataGridView1.Columns.Add("Source", "Source");
            dataGridView1.Columns.Add("Categorie", "Catégorie");
            dataGridView1.Columns.Add("Message", "Message");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Appliquer des styles aux colonnes et au texte
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            MessageBox.Show("Configuration de DataGridView terminée.", "Configuration terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedLog = listBox1.SelectedItem.ToString();
                MessageBox.Show("Journal sélectionné : " + selectedLog, "Sélection du journal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEvents(selectedLog);
            }
        }

        private void LoadEvents(string logName)
        {
            dataGridView1.Rows.Clear();
            eventEntries.Clear();

            try
            {
                var log = new EventLog(logName);

                foreach (EventLogEntry entry in log.Entries)
                {
                    eventEntries.Add(entry); // Ajouter chaque entrée à la liste temporaire
                    dataGridView1.Rows.Add(entry.EntryType, entry.TimeGenerated, entry.Source, entry.Category, entry.Message);
                }
                MessageBox.Show("Événements chargés depuis le journal : " + logName, "Chargement terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des événements : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton filtrer
        private void buttonFiltrer_Click(object sender, EventArgs e)
        {
            if (comboBoxFilterType.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de filtre.", "Erreur de filtre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filterType = comboBoxFilterType.SelectedItem.ToString();
            dataGridView1.Rows.Clear();

            foreach (var entry in eventEntries)
            {
                if (entry.EntryType.ToString() == filterType)
                {
                    dataGridView1.Rows.Add(entry.EntryType, entry.TimeGenerated, entry.Source, entry.Category, entry.Message);
                }
            }
            MessageBox.Show("Filtrage effectué sur le type : " + filterType, "Filtrage terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bouton supprimer logs sélectionnés
        private void buttonSuppr_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            MessageBox.Show("Les logs sélectionnés ont été supprimés.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bouton supprimer tous les logs affichés
        private void buttonToutSuppr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MessageBox.Show("Tous les logs affichés ont été supprimés.", "Suppression complète", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bouton quitter l'application
        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Bouton exporter en txt ou csv
        private void buttonExporter_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fichiers texte|*.txt|Fichiers CSV|*.csv";
                sfd.Title = "Exporter les logs filtrés";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        bool isCsv = Path.GetExtension(sfd.FileName).ToLower() == ".csv";

                        if (isCsv)
                        {
                            // En-tête CSV avec séparateur point-virgule
                            writer.WriteLine("Niveau;Date et Heure;Source;Catégorie;Message");
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                var niveau = row.Cells["Niveau"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                // Ajouter une apostrophe pour forcer le texte dans Excel
                                var dateEtHeure = "'" + row.Cells["DateEtHeure"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var source = row.Cells["Source"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var categorie = row.Cells["Categorie"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var message = row.Cells["Message"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");

                                // Encadrer chaque valeur de guillemets pour éviter les problèmes de format, et utiliser le point-virgule
                                writer.WriteLine($"\"{niveau}\";\"{dateEtHeure}\";\"{source}\";\"{categorie}\";\"{message}\"");
                            }
                        }
                        else
                        {
                            // Format texte avec tabulation
                            writer.WriteLine("Niveau\tDate et Heure\tSource\tCatégorie\tMessage");
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                var niveau = row.Cells["Niveau"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var dateEtHeure = "'" + row.Cells["DateEtHeure"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var source = row.Cells["Source"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var categorie = row.Cells["Categorie"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");
                                var message = row.Cells["Message"].Value?.ToString().Replace("\n", " ").Replace("\r", " ");

                                writer.WriteLine($"{niveau}\t{dateEtHeure}\t{source}\t{categorie}\t{message}");
                            }
                        }
                    }
                    MessageBox.Show("Les logs ont été exportés avec succès.", "Exportation réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
