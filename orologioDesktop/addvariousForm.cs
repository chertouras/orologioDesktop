using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
namespace orologioDesktop
{
    public partial class addvariousForm : Form
    {
        public addvariousForm()
        {
            InitializeComponent();
            ToolTip buttonToolTip = new ToolTip();

            buttonToolTip.ToolTipTitle = "Σημαντικό!";

            buttonToolTip.UseFading = true;

            buttonToolTip.UseAnimation = true;

            buttonToolTip.IsBalloon = true;



            buttonToolTip.ShowAlways = true;



            buttonToolTip.AutoPopDelay = 5000;

            buttonToolTip.InitialDelay = 300;

            buttonToolTip.ReshowDelay = 500;



            buttonToolTip.SetToolTip(new_db, "Αν υπάρχει ήδη το αρχείο daskaloi.db, θα παραμείνει ως έχει και δεν θα επαναδημιουργηθεί.  ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = (Form3)Tag;
            form3.Show();
            this.Close();
        }

        private void new_db_Click(object sender, EventArgs e)
        {
            long s1;
            if (System.IO.File.Exists("daskaloi.db"))
            {
                FileInfo f = new FileInfo("daskaloi.db");
                s1 = f.Length;
            }
            else s1 = 0;

            if (!System.IO.File.Exists("daskaloi.db") || (System.IO.File.Exists("daskaloi.db") && s1 == 0))
            {

                SQLiteConnection sqlite2;
                using (sqlite2 = new SQLiteConnection(@"Data Source=daskaloi.db;Version=3;foreign keys=True;"))
                {
                    sqlite2.Open();
                    string sql = @"





DROP TABLE IF EXISTS daskaloi.Taksi;
DROP TABLE IF EXISTS daskaloi.Daskaloi;
DROP TABLE IF EXISTS daskaloi.Imeres;
DROP TABLE IF EXISTS daskaloi.Tmimata;
DROP TABLE IF EXISTS daskaloi.Mathimata;
DROP TABLE IF EXISTS daskaloi.Programma;






CREATE TABLE Taksi (
	`id_taksi`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`onoma`	TEXT,
	`ImagePath`	TEXT
);
INSERT INTO `Taksi` (id_taksi,onoma,ImagePath) VALUES (1,'Α','Assets/LightGray.png');
INSERT INTO `Taksi` (id_taksi,onoma,ImagePath) VALUES (2,'Β','Assets/MediumGray.png');
INSERT INTO `Taksi` (id_taksi,onoma,ImagePath) VALUES (3,'Γ','Assets/DarkGray.png');
INSERT INTO `Taksi` (id_taksi,onoma,ImagePath) VALUES (4,'Δ','Assets/LightGray.png');
INSERT INTO `Taksi` (id_taksi,onoma,ImagePath) VALUES (5,'Ε','Assets/LightGray.png');
INSERT INTO `Taksi` (id_taksi,onoma,ImagePath) VALUES (6,'ΣΤ','Assets/DarkGray.png');

CREATE TABLE Daskaloi (
	`onoma`	TEXT,
	`epitheto`	TEXT,
	`email`	TEXT,
	`eidikotita`	TEXT,
	`biografiko`	TEXT,
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`ImagePath`	TEXT
);
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Κωνσταντίνος','Χερτούρας','chertour@sch.gr','ΠΕ19 - ΠΛΗΡΟΦΟΡΙΚΗΣ','1. Διπλωματούχος ΗΜΜΥ , Πολυτεχνείου Κρήτης 1998
2. MSc ECE , Imperial College, London 1999
3.MSc Πληροφορική , τμήμα ΗΜΜΥ , ΑΠΘ',1,'Assets/daskaloi/chertouras.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Γιώργος','Δάσκαλος1','mail@3dim.sch.gr','ΠΕ70 - ΔΑΣΚΑΛΟΣ','ΔΕΝ ΥΠΑΡΧΕΙ',2,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Ανδρέας','Δάσκαλος2','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΟΣ','ΔΕΝ ΥΠΑΡΧΕΙ',3,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Χριστίνα','Δασκάλα3','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',4,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Ρούλα','Δασκάλα4','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',5,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Καλλιόπη','Δασκάλα5','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',6,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Θεοδοσία','Δασκάλα6','mail@hotmail.com','ΠΕ70 - ΔΑΣΚΑΛΑ','Aπόφοιτος Παιδαγωγικού Τμήματος Δημοτικής Εκπαίδευσης του ΑΠΘ.
Κάτοχος First Certificate in English , University of Cambridge.
Πιστοποίηση στις ΤΠΕ , Α επιπέδου του ΥΠΕΠΘ.',7,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Φρόσω','Γυμναστής1','Δεν υπάρχει','ΠΕ11  - Φυσικής Αγωγής','ΔΕΝ ΥΠΑΡΧΕΙ',8,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Λεωνίδας','Γυμναστής2','Δεν υπάρχει','ΠΕ11  - Φυσικής Αγωγής','ΔΕΝ ΥΠΑΡΧΕΙ',9,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Χρύσα ','Δασκάλα7','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',10,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Μαρίνα','Δασκάλα8','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',11,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Χρήστος','Μουσικός','test@gmail.com','ΠΕ16 - Μουσικών Σπουδών','ΔΕΝ ΥΠΑΡΧΕΙ',12,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Δήμητρα','Δασκάλα9','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',13,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Δημήτρης','Δάσκαλος10','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΟΣ','ΔΕΝ ΥΠΑΡΧΕΙ',14,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Νίκος','Δάσκαλος11','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΟΣ','ΔΕΝ ΥΠΑΡΧΕΙ',15,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Θεοφανία','Δασκάλα12','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',16,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Δημητρούλα','Δασκάλα13','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',17,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Ολυμπία','Δασκάλα14','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',18,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Μαρία','Θεατρολόγος','Δεν υπάρχει','ΠΕ32 - Θεατρικών Σπουδών','ΔΕΝ ΥΠΑΡΧΕΙ',19,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Αθανασία ','Δασκάλα15','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',20,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Ελευθερία','Δασκάλα16','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',21,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Όλγα','Δασκάλα17','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',22,'Assets/daskaloi/nophoto.jpg');
INSERT INTO `Daskaloi` (onoma,epitheto,email,eidikotita,biografiko,id,ImagePath) VALUES ('Μαρία','Δασκάλα18','Δεν υπάρχει','ΠΕ70 - ΔΑΣΚΑΛΑ','ΔΕΝ ΥΠΑΡΧΕΙ',23,'Assets/daskaloi/nophoto.jpg');


CREATE TABLE Imeres (
	`id_imeres`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`onoma`	TEXT,
	`ImagePath`	TEXT
);
INSERT INTO `Imeres` (id_imeres,onoma,ImagePath) VALUES (1,'ΔΕΥΤΕΡΑ','Assets/LightGray.png');
INSERT INTO `Imeres` (id_imeres,onoma,ImagePath) VALUES (2,'ΤΡΙΤΗ','Assets/DarkGray.png');
INSERT INTO `Imeres` (id_imeres,onoma,ImagePath) VALUES (3,'ΤΕΤΑΡΤΗ','Assets/MediumGray.png');
INSERT INTO `Imeres` (id_imeres,onoma,ImagePath) VALUES (4,'ΠΕΜΠΤΗ','Assets/LightGray.png');
INSERT INTO `Imeres` (id_imeres,onoma,ImagePath) VALUES (5,'ΠΑΡΑΣΚΕΥΗ','Assets/DarkGray.png');




CREATE TABLE Tmimata (
	id_tmimata	INTEGER PRIMARY KEY AUTOINCREMENT,
	onoma	TEXT,
	`id_taksi`	INTEGER,
	`ImagePath`	TEXT,
	`id_daskalos`	INTEGER,
	FOREIGN KEY(`id_taksi`) REFERENCES `Taksi`(`id_taksi`) ON DELETE CASCADE,
FOREIGN KEY(`id_daskalos`) REFERENCES `Daskaloi`(`id`) ON DELETE SET NULL

);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (1,'Α1',1,'Assets/DarkGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (2,'Α2',1,'Assets/LightGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (3,'Α3',1,'Assets/MediumGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (4,'Β1',2,'Assets/DarkGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (5,'Β2',2,'Assets/LightGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (6,'Β3',2,'Assets/MediumGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (7,'Γ1',3,'Assets/DarkGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (8,'Γ2',3,'Assets/LightGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (9,'Δ1',4,'Assets/DarkGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (10,'Δ2',4,'Assets/LightGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (11,'Δ3',4,'Assets/MediumGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (12,'Ε1',5,'Assets/DarkGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (13,'Ε2',5,'Assets/LightGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (14,'Ε3',5,'Assets/MediumGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (15,'ΣΤ1',6,'Assets/DarkGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (16,'ΣΤ2',6,'Assets/LightGray.png',NULL);
INSERT INTO `Tmimata` (id_tmimata,onoma,id_taksi,ImagePath,id_daskalos) VALUES (17,'ΣΤ3',6,'Assets/MediumGray.png',NULL);
CREATE TABLE Mathimata (
	`id_mathimata`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`id_taksi`	INTEGER,
	`onoma`	TEXT,
	`ores`	INTEGER,
	FOREIGN KEY(`id_taksi`) REFERENCES Taksi(id_taksi) ON DELETE CASCADE
);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (1,1,'ΓΛΩΣΣΑ',9);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (2,1,'ΜΑΘΗΜΑΤΙΚΑ',5);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (3,1,'ΜΕΛΕΤΗ ΠΕΡΙΒΑΛΛΟΝΤΟΣ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (4,1,'ΕΙΚΑΣΤΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (5,1,'ΜΟΥΣΙΚΗ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (6,1,'ΘΕΑΤΡΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (7,1,'ΦΥΣΙΚΗ ΑΓΩΓΗ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (8,1,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΒΙΩΜΑΤΙΚΕΣ ΔΡΑΣΕΙΣ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (9,1,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΑΓΩΓΗ ΥΓΕΙΑΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (10,1,'ΤΕΧΝΟΛΟΓΙΕΣ ΤΗΣ ΠΛΗΡΟΦΟΡΙΑΣ ΚΑΙ ΤΩΝ ΕΠΙΚΟΙΝΩΝΙΩΝ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (11,1,'ΦΙΛΑΝΑΓΝΩΣΙΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (12,1,'ΧΟΡΟΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (13,2,'ΓΛΩΣΣΑ',9);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (14,2,'ΜΑΘΗΜΑΤΙΚΑ',5);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (15,2,'ΜΕΛΕΤΗ ΠΕΡΙΒΑΛΛΟΝΤΟΣ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (16,2,'ΕΙΚΑΣΤΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (17,2,'ΜΟΥΣΙΚΗ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (18,2,'ΘΕΑΤΡΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (19,2,'ΦΥΣΙΚΗ ΑΓΩΓΗ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (20,2,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΒΙΩΜΑΤΙΚΕΣ ΔΡΑΣΕΙΣ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (21,2,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΔΙΑΤΡΟΦΙΚΕΣ ΣΥΝΗΘΕΙΕΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (22,2,'ΤΕΧΝΟΛΟΓΙΕΣ ΤΗΣ ΠΛΗΡΟΦΟΡΙΑΣ ΚΑΙ ΤΩΝ ΕΠΙΚΟΙΝΩΝΙΩΝ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (23,2,'ΦΙΛΑΝΑΓΝΩΣΙΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (24,2,'ΧΟΡΟΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (25,1,'ΑΓΓΛΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (26,2,'ΑΓΓΛΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (27,3,'ΓΛΩΣΣΑ',7);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (28,3,'ΜΑΘΗΜΑΤΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (29,3,'ΙΣΤΟΡΙΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (30,3,'ΜΕΛΕΤΗ ΠΕΡΙΒΑΛΛΟΝΤΟΣ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (31,3,'ΕΙΚΑΣΤΙΚΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (32,3,'ΜΟΥΣΙΚΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (33,3,'ΘΕΑΤΡΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (34,3,'ΦΥΣΙΚΗ ΑΓΩΓΗ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (35,3,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΒΙΩΜΑΤΙΚΕΣ ΔΡΑΣΕΙΣ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (36,3,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΚΥΚΛΟΦΟΡΙΑΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (37,3,'ΤΕΧΝΟΛΟΓΙΕΣ ΤΗΣ ΠΛΗΡΟΦΟΡΙΑΣ ΚΑΙ ΤΩΝ ΕΠΙΚΟΙΝΩΝΙΩΝ (Τ.Π.Ε.)',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (38,3,'ΧΟΡΟΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (39,3,'ΦΙΛΑΝΑΓΝΩΣΙΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (40,3,'ΘΡΗΣΚΕΥΤΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (41,3,'ΑΓΓΛΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (42,4,'ΑΓΓΛΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (43,4,'ΘΡΗΣΚΕΥΤΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (44,4,'ΓΛΩΣΣΑ',7);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (45,4,'ΜΑΘΗΜΑΤΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (46,4,'ΙΣΤΟΡΙΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (47,4,'ΜΕΛΕΤΗ ΠΕΡΙΒΑΛΛΟΝΤΟΣ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (48,4,'ΕΙΚΑΣΤΙΚΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (49,4,'ΜΟΥΣΙΚΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (50,4,'ΘΕΑΤΡΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (51,4,'ΦΥΣΙΚΗ ΑΓΩΓΗ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (52,4,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΒΙΩΜΑΤΙΚΕΣ ΔΡΑΣΕΙΣ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (53,4,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΠΕΡΙΒΑΛΛΟΝΤΙΚΗ ΕΚΠΑΙΔΕΥΣΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (54,4,'ΤΕΧΝΟΛΟΓΙΕΣ ΤΗΣ ΠΛΗΡΟΦΟΡΙΑΣ ΚΑΙ ΤΩΝ ΕΠΙΚΟΙΝΩΝΙΩΝ (Τ.Π.Ε.)',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (55,4,'ΧΟΡΟΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (56,4,'ΦΙΛΑΝΑΓΝΩΣΙΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (57,5,'ΘΡΗΣΚΕΥΤΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (58,5,'ΓΛΩΣΣΑ',6);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (59,5,'ΜΑΘΗΜΑΤΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (60,5,'ΙΣΤΟΡΙΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (61,5,'ΓΕΩΓΡΑΦΙΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (62,5,'ΦΥΣΙΚΑ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (63,5,'ΚΟΙΝΩΝΙΚΗ ΚΑΙ ΠΟΛΙΤΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (64,5,'ΕΙΚΑΣΤΙΚΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (65,5,'ΜΟΥΣΙΚΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (66,5,'ΘΕΑΤΡΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (67,5,'ΦΥΣΙΚΗ ΑΓΩΓΗ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (68,5,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΒΙΩΜΑΤΙΚΕΣ ΔΡΑΣΕΙΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (69,5,'ΤΕΧΝΟΛΟΓΙΕΣ ΤΗΣ ΠΛΗΡΟΦΟΡΙΑΣ ΚΑΙ ΤΩΝ ΕΠΙΚΟΙΝΩΝΙΩΝ (Τ.Π.Ε.)',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (70,5,'ΦΙΛΑΝΑΓΝΩΣΙΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (71,5,'ΑΓΓΛΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (72,5,'ΓΑΛΛΙΚΑ / ΓΕΡΜΑΝΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (73,6,'ΓΛΩΣΣΑ',6);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (74,6,'ΜΑΘΗΜΑΤΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (75,6,'ΙΣΤΟΡΙΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (76,6,'ΓΕΩΓΡΑΦΙΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (77,6,'ΦΥΣΙΚΑ',3);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (78,6,'ΚΟΙΝΩΝΙΚΗ ΚΑΙ ΠΟΛΙΤΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (79,6,'ΕΙΚΑΣΤΙΚΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (80,6,'ΜΟΥΣΙΚΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (81,6,'ΘΕΑΤΡΙΚΗ ΑΓΩΓΗ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (82,6,'ΦΥΣΙΚΗ ΑΓΩΓΗ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (83,6,'ΕΥΕΛΙΚΤΗ ΖΩΝΗ: ΒΙΩΜΑΤΙΚΕΣ ΔΡΑΣΕΙΣ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (84,6,'ΤΕΧΝΟΛΟΓΙΕΣ ΤΗΣ ΠΛΗΡΟΦΟΡΙΑΣ ΚΑΙ ΤΩΝ ΕΠΙΚΟΙΝΩΝΙΩΝ (Τ.Π.Ε.)',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (85,6,'ΦΙΛΑΝΑΓΝΩΣΙΑ',1);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (86,6,'ΑΓΓΛΙΚΑ',4);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (87,6,'ΓΑΛΛΙΚΑ / ΓΕΡΜΑΝΙΚΑ',2);
INSERT INTO `Mathimata` (id_mathimata,id_taksi,onoma,ores) VALUES (88,6,'ΘΡΗΣΚΕΥΤΙΚΑ',2);


CREATE TABLE Programma (
	`id_programma`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`id_tmimata`	INTEGER,
	`id_daskaloi`	INTEGER,
	`id_imeres`	INTEGER,
	`ora`	INTEGER,
	`id_mathimata`	INTEGER,
	`id_taksi`	INTEGER,
	FOREIGN KEY(`id_tmimata`) REFERENCES `Tmimata`(`id_tmimata`) ON DELETE CASCADE,
	FOREIGN KEY(`id_daskaloi`) REFERENCES `Daskaloi`(`id`) ON DELETE SET NULL,
	FOREIGN KEY(`id_imeres`) REFERENCES `Imeres`(`id_imeres`) ON DELETE SET NULL,
	FOREIGN KEY(`id_mathimata`) REFERENCES `Mathimata`(`id_mathimata`) ON DELETE CASCADE,
	FOREIGN KEY(`id_taksi`) REFERENCES Taksi(id_taksi) ON DELETE CASCADE
);


CREATE TRIGGER update_program
AFTER UPDATE OF id_daskalos ON Tmimata
BEGIN
    UPDATE Programma SET id_daskaloi = NEW.id_daskalos  WHERE id_tmimata = OLD.id_tmimata;
   
END";





                    try
                    {

                        Cursor.Current = Cursors.WaitCursor;
                        SQLiteCommand command = new SQLiteCommand(sql, sqlite2);
                        command.ExecuteNonQuery();
                        Cursor.Current = Cursors.AppStarting;
                        MessageBox.Show("H βάση δεδομένων δημιουργήθηκε επιτυχώς");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    finally
                    {
                        sqlite2.Close();
                    };







                }
            }

            else
                MessageBox.Show("Υπάρχει βάση δεδομένων");



        }
    }
}
