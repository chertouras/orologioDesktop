# orologioDesktop


Η εφαρμογή orologioDesktop αποτελεί τη συνοδευτική εφαρμογή που δημιουργήθηκε για να υποστηρίξει την εύκολη δημιουργία του αρχείου βάσης δεδομένων daskaloi.db που περιλαμβάνει το ωρολόγιο πρόγραμμα και τα λοιπά στοιχεία του κάθε σχολείου που θα προβληθούν από την εφαρμογή κινητού τηλεφώνου winphonesqlite. 

Αποτελεί μια εφαρμογή winforms γραμμένη σε C# και περιλαμβάνει το σύνολο των απαραίτητων λειτουργιών για να γίνει διαχείριση της βάσης δεδομένων (SQLite) του ωρολογίου προγράμματος. 

Υπάρχουν οι εξής επιλογές από το αρχικό μενού της εφαρμογής:
![Εικόνα 1/6](http://users.sch.gr/chertour/orologioDesktop/1.png)

1.	**Δημιουργία βάσης δεδομένων**: Με τη χρήση της εν λόγω επιλογής, δημιουργείται ένα αρχικό αρχείο με το όνομα daskaloi.db (η αρχική έκδοση αφορούσε δημοτικό σχολείο), το οποίο συμπληρώνει αυτόματα τους πίνακες της βάσης δεδομένων με στοιχεία που αφορούν το τωρινό πρόγραμμα ενός ΕΑΕΠ δημοτικού σχολείου ( το οποίο από το σχολικό έτος 2016 - 2017 θα έχει αλλαγές). Το αρχείο δημιουργείται στο φάκελο  **\orologioDesktop\bin\x86\Debug** εφόσον είμαστε σε Debug Mode στο περιβάλλον του Visual Studio και έχω επιλέξει ως αρχιτεκτονική την x86 (επιλογές που ορίζονται στο Build -> Configuration Manager), που είναι και το default. **Είναι σημαντικό να δημιουργηθεί μια βάση δεδομένων πριν τη χρήση της εφαρμογής ή να παραμείνει η υπάρχουσα βάση δεδομένων που διανέμεται μαζί με την εφαρμογή ( χρήσιμη για λόγους δοκιμής – όμοια με αυτή που παράγεται από την εφαρμογή).**  

>**Στην περίπτωση επιθυμίας χρήσης της εφαρμογής ως Standalone ( χρήση μόνο της έκδοσης με τα  executables και  χωρίς  τη χρήση του Visual Studio 2013 και νεώτερο ) μπορεί κάποιος να χρησιμοποιήσει το εργαλείο DB Browser for SQLite (διαθέσιμο στο http://sqlitebrowser.org/) και να κάνει απευθείας εισαγωγή ή τροποποίηση δεδομένων.** 	

2.	**Διαχείριση Τάξεων / Τμημάτων / Εκπαιδευτικών** : Οι επιλογές αυτές επιτρέπουν την εισαγωγή / τροποποίηση / διαγραφή των αντίστοιχων εννοιών που «χειρίζεται» η κάθε επιλογή. Ως πρώτο βήμα κάθε φορά, είναι η επιλογή «φόρτωση δεδομένων» ώστε να φορτωθούν τα όποια στοιχεία υπάρχουν στους αντίστοιχούς πίνακες της βάσης δεδομένων. Στην συνέχεια και για οποιαδήποτε προσθήκη / τροποποίηση των στοιχείων της βάσης δεδομένων πρέπει να γίνει click στην επιλογή  **Προσθήκη / Ενημέρωση**. Χωρίς τη χρήση της επιλογής **Προσθήκη / Ενημέρωση** δεν μπορεί να γίνει καμία επέμβαση στο κάθε datagridview που φιλοξενεί το σύνολο των δεδομένων σε όλες τις φόρμες του προγράμματος. Η στήλη ImagePath περιλαμβάνει το όνομα του αρχείου φωτογραφίας ώστε να μπορεί να προβληθεί η φωτογραφία του εκπαιδευτικού στην εφαρμογή του κινητού τηλεφώνου. Δεν επιτρέπεται η αλλαγή του path (/Assets/daskaloi) γιατί θα πρέπει να τροποποιηθεί αντίστοιχά και η εφαρμογή του κινητού τηλεφώνου που φορτώνει τις φωτογραφίες από τον συγκεκριμένο φάκελο. 

3.**Προσοχή: Σε κάθε τμήμα και υποχρεωτικά πρέπει να δηλωθεί ο δάσκαλος του, πρίν γίνουν εισαγωγές για αυτό το τμήμα στο ωρολόγιο πρόγραμμα.**
Παρακάτω εμφανίζονται μερικές ενδεικτικές οθόνες της εφαρμογής: 

![Εικόνα 2/6](http://users.sch.gr/chertour/orologioDesktop/2.png)

![Εικόνα 3/6](http://users.sch.gr/chertour/orologioDesktop/3.png)

![Εικόνα 4/6](http://users.sch.gr/chertour/orologioDesktop/4.png)

4.	Εισαγωγή Προγράμματος: Η εισαγωγή του ωρολογίου προγράμματος γίνεται με απλή επιλογή από το σύνολο των επιλογών που περιλαμβάνουν την ώρα, μέρα, εκπαιδευτικό κλπ και στην συνέχεια με click την επιλογή αποθήκευση. Με την αποθήκευση δημιουργείται μια εγγραφή στη βάση δεδομένων και στον αντίστοιχο πίνακα. Υπάρχουν φίλτρα στα selectboxes ώστε να γίνεται ευκολότερος ο περιορισμός των επιλογών και δυσκολότερο το να γίνει λάθος (πχ αν κάποιος επιλέξει Α τάξης τότε αυτόματα ενημερώνεται η λίστα με τα τμήματα της Α τάξης και η λίστα με τα μαθήματα ώστε να αντιστοιχεί στα μαθήματα της Α τάξης). 

![Εικόνα 5/6](http://users.sch.gr/chertour/orologioDesktop/5.png)

5.	Τροποποίηση Προγράμματος: Η τροποποίηση στην περίπτωση λάθους ή επιθυμίας αλλαγών γίνεται με την επιλογή **Τροποποίηση Προγράμματος** από την αρχική οθόνη επιλογών της εφαρμογής. Εκεί ο χρήστης, αφού επιλέξει την εγγραφή που θέλει να τροποποιήσει ενημερώνονται αυτόματα και τα αντίστοιχα πεδία της φόρμας ώστε να γίνει δυνατή η αλλαγή των στοιχείων.

![Εικόνα 6/6](http://users.sch.gr/chertour/orologioDesktop/6.png)

6.	**Σημαντικές παρατηρήσεις για τα foreign keys και τις διαγραφές**: Στην εφαρμογή έχουν γίνει μερικές στρατηγικές επιλογές για τον χειρισμό των διαγραφών στοιχείων από τη βάση δεδομένων (χωρίς αυτό να σημαίνει ότι είναι και οι μοναδικές και ίσως οι καλύτερες). Έχουν τεθεί ένα σύνολο από κανόνες οι οποίοι συνοψίζονται στα εξής:
Α. Αν διαγραφεί μια τάξη διαγράφονται τα μαθήματα, τα τμήματα, και το σύνολο των εγγραφών του προγράμματος που είναι δηλωμένα σε αυτήν.
Β. Αν διαγραφεί ένα τμήμα τότε θα διαγραφεί και το σύνολο των εγγραφών του προγράμματος που είναι δηλωμένα σε αυτό. Ο δάσκαλος του τμήματος θα παραμείνει ως εγγραφή στην βάση δεδομένων. 
Γ. Αν διαγραφεί ένας  δάσκαλος τότε οι εγγραφές του προγράμματος που τον αφορούν παραμένουν στη βάση δεδομένων και το πεδίο id_daskaloi τίθεται σε null. **Ως αποτέλεσμα οι εγγραφές υπάρχουν ακόμη αλλά δεν εμφανίζονται ούτε στην Εισαγωγή ούτε στην Τροποποίηση προγράμματος**. ***ΠΡΟΣΟΧΗ : Όταν επιλεγεί νέος δάσκαλος για να αναλάβει το τμήμα, του ανατίθεται το σύνολο των μαθημάτων και θα πρέπει να γίνουν οι τροποποιήσεις όπου απαιτούνται (π.χ να τοποθετηθεί ο Γυμναστής στην ώρα της Φυσικής Αγωγής).  Η επιλογή αυτή μπορεί εύκολα να αλλάξει με επέμβαση στους κανόνες των foreign keys και με την αφαίρεση του trigger που δημιουργήθηκε***.   Να σημειωθεί ότι αποεπιλέγεται (set null) η ανάθεση του δασκάλου ως υπεύθυνου τάξης. 
Δ. Αν διαγραφεί ένα μάθημα τότε διαγράφεται και το σύνολο των εγγραφών του προγράμματος που αφορούν το εν λόγω  μάθημα.

**Το σύνολο των κανόνων των foreign keys, το schema της βάσης δεδομένων καθώς και ένα δειγματικό trigger δίνονται παρακάτω:**

        CREATE TABLE "Tmimata" (
    	`id_tmimata`	INTEGER PRIMARY KEY AUTOINCREMENT,
    	`onoma`	TEXT,
    	`id_taksi`	INTEGER,
    	`ImagePath`	TEXT,
    	`id_daskalos`	INTEGER,
    	FOREIGN KEY(`id_taksi`) REFERENCES `Taksi`(`id_taksi`) ON DELETE CASCADE,
    	FOREIGN KEY(`id_daskalos`) REFERENCES `Daskaloi`(`id`) ON DELETE SET NULL
    );


    CREATE TABLE Taksi (
    	`id_taksi`	INTEGER PRIMARY KEY AUTOINCREMENT,
    	`onoma`	TEXT,
    	`ImagePath`	TEXT
    );
    
    
    CREATE TABLE "Programma" (
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
    	FOREIGN KEY(`id_mathimata`) REFERENCES `Mathimata`(`id_mathimata`) 
    ON DELETE CASCADE,
    	FOREIGN KEY(`id_taksi`) REFERENCES `Taksi`(`id_taksi`) ON DELETE CASCADE
    );
    
    CREATE TABLE Mathimata (
    	`id_mathimata`	INTEGER PRIMARY KEY AUTOINCREMENT,
    	`id_taksi`	INTEGER,
    	`onoma`	TEXT,
    	`ores`	INTEGER,
    	FOREIGN KEY(`id_taksi`) REFERENCES Taksi(id_taksi) ON DELETE CASCADE
    );
    
    CREATE TABLE Imeres (
    	`id_imeres`	INTEGER PRIMARY KEY AUTOINCREMENT,
    	`onoma`	TEXT,
    	`ImagePath`	TEXT
    );
    
    
    
    CREATE TABLE Daskaloi (
    	`onoma`	TEXT,
    	`epitheto`	TEXT,
    	`email`	TEXT,
    	`eidikotita`	TEXT,
    	`biografiko`	TEXT,
    	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
    	`ImagePath`	TEXT
    );
    
    
    
    
    CREATE TRIGGER update_program
    AFTER UPDATE OF id_daskalos ON Tmimata
    BEGIN
        UPDATE Programma SET id_daskaloi = NEW.id_daskalos  WHERE id_tmimata = OLD.id_tmimata;
    END;
    COMMIT;

Σημειώσεις: Παρά το ότι έχει καταβληθεί μεγάλη προσπάθεια ώστε στις σύντομες αυτές οδηγίες χρήσης να περιγραφούν όσες περισσότερες δυνατότητες της εφαρμογής καθώς και οι περιορισμοί της, σίγουρα δεν έχουν δοκιμαστεί όλες οι περιπτώσεις. Επίσης παρά την κατά το δυνατό αποσφαλμάτωση της εφαρμογής, είναι πιθανό να υπάρχουν και προβλήματα που δεν εντοπίστηκαν.   


Η εφαρμογή παρουσιάστηκε στο 10ο Πανελλήνιο Συνέδριο Καθηγητών Πληροφορικής που διοργανώθηκε στο Ναύπλιο τον Απρίλιο του 2016. Μπορείτε να δείτε μια σύντομη περιγραφή της [εδώ] (http://users.sch.gr/chertour/pekapchertouras2016.pdf).

Άδεια: Δεν υπάρχει κανένας απολύτως περιορισμός στην χρήση, τροποποίηση, και δημοσίευση της εφαρμογής. Δεν δίνεται καμία εγγύηση και δεν φέρεται καμία ευθύνη από την μεριά μου για τη χρήση της. 

Άδεια (GPL v3.0 του FSF). 

Ελπίζω έστω και ένας συνάδελφος ή γονιός να επωφεληθεί. 

>Δημιουργός : 
Κωνσταντίνος Χερτούρας Διπλωματούχος Σχολής ΗΜΜΥ, 
Πολυτεχνείο Κρήτης, 1998
MSc ECE , Imperial College , London, 1999
MSc Πληροφορική, τμ. ΗΜΜΥ , Πολυτεχνική Σχολή , ΑΠΘ, 2005
Εκπαιδευτικός Β’Θμιας Εκπαίδευσης , ΕΠΑΛ Ροδόπολης Σερρών 

Ευχαριστίες: 
Ευχαριστώ τους φίλους και συμφοιτητές μου στο Πολυτεχνείο Κρήτης
Γιάννη Γεωργιάδη (PhD Computer Science, Imperial College, London)
και Βλάσιο Τσιάτση (MSEE, PhD Electrical Engineering, UC Los Angeles)
για τις πολύτιμες παρατηρήσεις τους. 
