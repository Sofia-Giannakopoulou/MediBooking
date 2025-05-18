using MediBooking.DataAccessLayer;
using MediBooking.Enums;
using MediBooking.Models;

namespace MediBooking.DatabaseSeeder
{
    public class DbInitializer
    {
        public static void SeedUsers(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<DataContext>();

            var users = new List<User>
            {
                // 🧍‍♂️ Γιώργος Φωτόπουλος (Patient)
                new User
                {
                    FirstName      = "Γιώργος",
                    LastName       = "Φωτόπουλος",
                    UserRole       = UserRole.Patient,
                    Amka           = "12051980321",
                    Sex            = Sex.Male,
                    Age            = 29,
                    PatientHistory = "Περιοδικός έλεγχος καρδιαγγειακής υγείας, χωρίς σημαντικά ευρήματα. Ήπια υπέρταση.\r\n\r\n",
                    Notes          = "Υποβλήθηκε σε γενικό ιατρικό έλεγχο. Δεν αναφέρονται άμεσα προβλήματα. Συνίσταται περιοδική παρακολούθηση πίεσης και χοληστερίνης ανά εξάμηνο.",
                    Location       = "Μαρούσι",
                    Username       = "user01",
                    Password       = "pass01",
                    ProfilePicture = "/uploads/Grande.jpg"
                },

                // 🧍‍♀️ Σοφία Γιαννακοπούλου (Admin)
                new User
                {
                    FirstName      = "Σοφία",
                    LastName       = "Γιαννακοπούλου",
                    Sex            = Sex.Female,
                    Age            = 33,
                    UserRole       = UserRole.Admin,
                    Location       = "Νέα Χαλκηδόνα",
                    Username       = "user02",
                    Password       = "pass02",
                    ProfilePicture = "/uploads/Sofia.jpg"
                },

                // 🧍‍♂️ Θωμάς Μπενχάφση (Admin)
                new User
                {
                    FirstName      = "Θωμάς",
                    LastName       = "Μπενχάφση",
                    Sex            = Sex.Male,
                    Age            = 32,
                    UserRole       = UserRole.Admin,
                    Location       = "Πεύκη",
                    Username       = "user03",
                    Password       = "pass03",
                    ProfilePicture = "/uploads/thomas.jpg"
                },

                // 🧍‍♂️ Ιάσονας Σοφιανόπουλος (Patient)
                new User
                {
                    FirstName      = "Ιάσονας",
                    LastName       = "Σοφιανόπουλος",
                    UserRole       = UserRole.Patient,
                    Amka           = "01012000459",
                    Sex            = Sex.Other,
                    Age            = 32,
                    PatientHistory = "Δίαιτα για μείωση λιπώδους ιστού. Επιτυχής απώλεια βάρους 8 κιλών τους τελευταίους 5 μήνες.",
                    Notes          = "Σε στάδιο συντήρησης διατροφικού πλάνου. Έχει ανταποκριθεί θετικά. Επόμενη παρακολούθηση σε δύο μήνες.",
                    Location       = "Κατ",
                    Username       = "user04",
                    Password       = "pass04",
                    ProfilePicture = "/uploads/Jason.jpg"
                },

                // 🧑‍⚕️ Κώστας Καλογερόπουλος (Doctor)
                new User
                {
                    FirstName      = "Κώστας",
                    LastName       = "Καλογερόπουλος",
                    UserRole       = UserRole.Doctor,
                    Amka           = "14101985213",
                    PatientHistory = "",
                    Notes          = "",
                    Location       = "Κηφισιά",
                    Username       = "user05",
                    Password       = "pass05",
                    ProfilePicture = "/uploads/Kataigidas.jpg"
                },

                // 🧍‍♂️ Νίκος Βασιλείου (Patient)
                new User
                {
                    FirstName      = "Νίκος",
                    LastName       = "Βασιλείου",
                    UserRole       = UserRole.Patient,
                    Amka           = "22071976236",
                    Sex            = Sex.Male,
                    Age            = 32,
                    PatientHistory = "Ατύχημα με μαχαίρι το 2023 – επείγουσα χειρουργική επανένωση δεξιού αντίχειρα. Αποκατάσταση σε εξέλιξη.\r\n\r\n",
                    Notes          = "Επανεγκατάσταση αντίχειρα. Σε φάση επούλωσης. Συνιστάται αποφυγή χειρωνακτικών εργασιών. Επανέλεγχος σε 6 εβδομάδες.",
                    Location       = "Δροσιά",
                    Username       = "user06",
                    Password       = "pass06",
                    ProfilePicture = "/uploads/Vasileiou.jpg"
                },

                // 🧍‍♀️ Θωμαή Σοφιανοπούλου (Patient)
                new User
                {
                    FirstName      = "Θωμαή",
                    LastName       = "Σοφιανοπούλου",
                    UserRole       = UserRole.Patient,
                    Amka           = "05082001333",
                    Sex            = Sex.Female,
                    Age            = 29,
                    PatientHistory = "Συχνοί πονοκέφαλοι και αυχενικό σύνδρομο. Αρχικά διάγνωση για ημικρανίες. Αναμονή για νευρολογική εξέταση.",
                    Notes          = "Συχνοί πονοκέφαλοι — πιθανή ημικρανία. Έγινε σύσταση για μαγνητική εγκεφάλου και ημερολόγιο συμπτωμάτων. Προσωρινή φαρμακευτική αγωγή με παυσίπονα.",
                    Location       = "Κατ",
                    Username       = "user07",
                    Password       = "pass07",
                    ProfilePicture = "/uploads/Thomi.jpg"
                },

                // 🧍‍♀️ Μαρίλια Ρόδη (Patient)
                new User
                {
                    FirstName      = "Μαρίλια",
                    LastName       = "Ρόδη",
                    UserRole       = UserRole.Patient,
                    Amka           = "30041993392",
                    Sex            = Sex.Female,
                    Age            = 28,
                    PatientHistory = "Λοίμωξη HPV (κονδυλώματα). Υπό θεραπεία με τοπικά σκευάσματα. Ψυχολογική επιβάρυνση λόγω της διάγνωσης.",
                    Notes          = "Εν εξελίξει θεραπεία για HPV κονδυλώματα. Συνίσταται τακτική γυναικολογική παρακολούθηση. Προτάθηκε ψυχολογική υποστήριξη λόγω άγχους.",
                    Location       = "Παρίσι",
                    Username       = "user08",
                    Password       = "pass08",
                    ProfilePicture = "/uploads/Marilia.jpg"
                },

                // 🧍‍♂️ Πάρης Τάφας (Patient)
                new User
                {
                    FirstName      = "Πάρης",
                    LastName       = "Τάφας",
                    UserRole       = UserRole.Patient,
                    Amka           = "08031984406",
                    Sex            = Sex.Male,
                    Age            = 32,
                    PatientHistory = "Πτώση στο σπίτι. Μυοσκελετικός πόνος χωρίς κάταγμα. Ιστορικό καπνίσματος 1 πακέτο/ημέρα.",
                    Notes          = "Κακώσεις από πτώση. Δεν εντοπίστηκαν κατάγματα. Αντιφλεγμονώδη και φυσιοθεραπεία για 2 εβδομάδες. Επανέλεγχος βάδισης σε 10 ημέρες.",
                    Location       = "Βριλήσσια",
                    Username       = "user09",
                    Password       = "pass09",
                    ProfilePicture = "/uploads/Paris.jpg"
                },

                // 🧍‍♂️ Μικρός Φωτόπουλος (Patient)
                new User
                {
                    FirstName      = "Μικρός",
                    LastName       = "Φωτόπουλος",
                    UserRole       = UserRole.Patient,
                    Amka           = "17072010328",
                    Sex            = Sex.Male,
                    Age            = 29,
                    PatientHistory = "Υπερβολική υπνηλία τις βραδινές ώρες. Εμφάνιση νυσταγμού και διαλείπουσας απώλειας επαφής. Πιθανή ναρκοληψία.",
                    Notes          = "Αναφέρονται επεισόδια υπνηλίας μετά τις 21:00. Ύποπτο για ήπια μορφή ναρκοληψίας. Προτείνεται πολυϋπνογράφημα.",
                    Location       = "Μαρούσι",
                    Username       = "user10",
                    Password       = "pass10",
                    ProfilePicture = "/uploads/MikrosF.jpg"
                },

                // 🧍‍♂️ Αράκις Γιαννακόπουλος (Patient)
                new User
                {
                    FirstName      = "Αράκις",
                    LastName       = "Γιαννακόπουλος",
                    UserRole       = UserRole.Patient,
                    Amka           = "10121992275",
                    Sex            = Sex.Male,
                    Age            = 13,
                    PatientHistory = "Χρόνια στομαχικά προβλήματα, αλλεργική δερματίτιδα, αρθροπάθεια. Διάγνωση: καλοήθης υπερπλασία προστάτη.",
                    Notes          = "Εξέλιξη θετική όσον αφορά στομαχικά. Παραμένει διόγκωση προστάτη. Συνεχίζεται φαρμακευτική αγωγή. Απαιτείται επανέλεγχος PSA σε 2 μήνες.",
                    Location       = "Νέα Χαλκηδόνα",
                    Username       = "user11",
                    Password       = "pass11",
                    ProfilePicture = "/uploads/aro.jpg"
                },

                // 🧑‍⚕️ Ρωμανός Κεφαλίδης (Doctor)
                new User
                {
                    FirstName      = "Ρωμανός",
                    LastName       = "Κεφαλίδης",
                    UserRole       = UserRole.Doctor,
                    Amka           = "10121991275",
                    PatientHistory = "",
                    Notes          = "",
                    Location       = "Νέα Χαλκηδόνα",
                    Username       = "user12",
                    Password       = "pass12",
                    ProfilePicture = "/uploads/rwmanos.jpg"
                },
                // 🧑‍⚕️ Αναστάσιος Χατζής (Doctor)
                new User
                {
                    FirstName = "Αναστάσιος",
                    LastName = "Χατζής",
                    UserRole = UserRole.Doctor,
                    Amka = "19508297028",
                    PatientHistory = "",
                    Notes = "",
                    Location = "Καλαμαριά",
                    Username = "doc01",
                    Password = "docpass01",
                    ProfilePicture = "/uploads/doctor01.jpg"
                },
                // 🧑‍⚕️ Διονύσιος Καραγιάννης (Doctor)
                new User {
                    FirstName = "Διονύσιος",
                    LastName = "Καραγιάννης",
                    UserRole = UserRole.Doctor,
                    Amka = "75394181238",
                    PatientHistory = "",
                    Notes = "",
                    Location = "Ηλιούπολη",
                    Username = "doc02",
                    Password = "docpass02",
                    ProfilePicture = "/uploads/doctor02.jpg"
                },
                // 🧑‍⚕️ Νεκτάριος Αναγνώστου (Doctor)
                new User {
                    FirstName = "Νεκτάριος",
                    LastName = "Αναγνώστου",
                    UserRole = UserRole.Doctor,
                    Amka = "25974910038",
                    PatientHistory = "",
                    Notes = "",
                    Location = "Γλυφάδα",
                    Username = "doc03",
                    Password = "docpass03",
                    ProfilePicture = "/uploads/doctor03.jpg"
                },
                // 🧑‍⚕️ Θεμιστοκλής Βλάχος (Doctor)
                new User {
                    FirstName = "Θεμιστοκλής",
                    LastName = "Βλάχος",
                    UserRole = UserRole.Doctor,
                    Amka = "03265048647",
                    PatientHistory = "",
                    Notes = "",
                    Location = "Κηφισιά",
                    Username = "doc04",
                    Password = "docpass04",
                    ProfilePicture = "/uploads/doctor04.jpg"
                },
                // 🧑‍⚕️ Πολύκαρπος Λεμονής (Doctor)
                new User {
                FirstName = "Πολύκαρπος",
                LastName = "Λεμονής",
                UserRole = UserRole.Doctor,
                Amka = "67153270491",
                PatientHistory = "",
                Notes = "",
                Location = "Πετρούπολη",
                Username = "doc05",
                Password = "docpass05",
                ProfilePicture = "/uploads/doctor05.jpg"
            },
                // 🧑‍⚕️ Ευστράτιος Γεωργακόπουλος (Doctor)
            new User {
                FirstName = "Ευστράτιος",
                LastName = "Γεωργακόπουλος",
                UserRole = UserRole.Doctor,
                Amka = "97024816302",
                PatientHistory = "",
                Notes = "",
                Location = "Καλαμαριά",
                Username = "doc06",
                Password = "docpass06",
                ProfilePicture = "/uploads/doctor06.jpg"
            },
            // 🧑‍⚕️ Ιωάννης Μακρής (Doctor)
            new User {
                FirstName = "Ιωάννης",
                LastName = "Μακρής",
                UserRole = UserRole.Doctor,
                Amka = "64328710973",
                PatientHistory = "",
                Notes = "",
                Location = "Κορυδαλλός",
                Username = "doc07",
                Password = "docpass07",
                ProfilePicture = "/uploads/doctor07.jpg"
            },
             // 🧑‍⚕️ Θεόδωρος Σιταράς (Doctor)
            new User {
                FirstName = "Θεόδωρος",
                LastName = "Σιταράς",
                UserRole = UserRole.Doctor,
                Amka = "20489173521",
                PatientHistory = "",
                Notes = "",
                Location = "Καλλιθέα",
                Username = "doc08",
                Password = "docpass08",
                ProfilePicture = "/uploads/doctor08.jpg"
            },
            // 🧑‍⚕️ Χρήστος Σπανούδης (Doctor)
            new User {
                FirstName = "Χρήστος",
                LastName = "Σπανούδης",
                UserRole = UserRole.Doctor,
                Amka = "95140782361",
                PatientHistory = "",
                Notes = "",
                Location = "Νέα Ιωνία",
                Username = "doc09",
                Password = "docpass09",
                ProfilePicture = "/uploads/doctor09.jpg"
            },
             // 🧑‍⚕️ Γεράσιμος Σιδέρης (Doctor)
            new User {
                FirstName = "Γεράσιμος",
                LastName = "Σιδέρης",
                UserRole = UserRole.Doctor,
                Amka = "47318269041",
                PatientHistory = "",
                Notes = "",
                Location = "Πάτρα",
                Username = "doc10",
                Password = "docpass10",
                ProfilePicture = "/uploads/doctor10.jpg"
            },
            // 🧑‍⚕️ Στυλιανός Φραγκούλης (Doctor)
            new User {
                FirstName = "Στυλιανός",
                LastName = "Φραγκούλης",
                UserRole = UserRole.Doctor,
                Amka = "38592741603",
                PatientHistory = "",
                Notes = "",
                Location = "Χαλάνδρι",
                Username = "doc11",
                Password = "docpass11",
                ProfilePicture = "/uploads/doctor11.jpg"
            },
            // 🧑‍⚕️ Αριστείδης Μπούρας (Doctor)
            new User {
                FirstName = "Αριστείδης",
                LastName = "Μπούρας",
                UserRole = UserRole.Doctor,
                Amka = "40298713562",
                PatientHistory = "",
                Notes = "",
                Location = "Λάρισα",
                Username = "doc12",
                Password = "docpass12",
                ProfilePicture = "/uploads/doctor12.jpg"
            },
            // 🧑‍⚕️ Ευάγγελος Διαμαντής (Doctor)
            new User {
                FirstName = "Ευάγγελος",
                LastName = "Διαμαντής",
                UserRole = UserRole.Doctor,
                Amka = "61472830570",
                PatientHistory = "",
                Notes = "",
                Location = "Βόλος",
                Username = "doc13",
                Password = "docpass13",
                ProfilePicture = "/uploads/doctor13.jpg"
            },
            // 🧑‍⚕️ Μιλτιάδης Τερζόπουλος (Doctor)
            new User {
                FirstName = "Μιλτιάδης",
                LastName = "Τερζόπουλος",
                UserRole = UserRole.Doctor,
                Amka = "98423106743",
                PatientHistory = "",
                Notes = "",
                Location = "Ιωάννινα",
                Username = "doc14",
                Password = "docpass14",
                ProfilePicture = "/uploads/doctor14.jpg"
            },
             // 🧑‍⚕️ Ηρακλής Ζέρβας (Doctor)
            new User {
                FirstName = "Ηρακλής",
                LastName = "Ζέρβας",
                UserRole = UserRole.Doctor,
                Amka = "12085749613",
                PatientHistory = "",
                Notes = "",
                Location = "Ηράκλειο",
                Username = "doc15",
                Password = "docpass15",
                ProfilePicture = "/uploads/doctor15.jpg"
            },
            // 🧑‍⚕️ Λουκάς Καρατζάς (Doctor)
            new User {
                FirstName = "Λουκάς",
                LastName = "Καρατζάς",
                UserRole = UserRole.Doctor,
                Amka = "30842150986",
                PatientHistory = "",
                Notes = "",
                Location = "Κως",
                Username = "doc16",
                Password = "docpass16",
                ProfilePicture = "/uploads/doctor16.jpg"
            },
            // 🧑‍⚕️ Περικλής Νικολόπουλος (Doctor)
            new User {
                FirstName = "Περικλής",
                LastName = "Νικολόπουλος",
                UserRole = UserRole.Doctor,
                Amka = "71820469370",
                PatientHistory = "",
                Notes = "",
                Location = "Ρόδος",
                Username = "doc17",
                Password = "docpass17",
                ProfilePicture = "/uploads/doctor17.jpg"
            },
            // 🧑‍⚕️ Ορέστης Γαλάνης (Doctor)
            new User {
                FirstName = "Ορέστης",
                LastName = "Γαλάνης",
                UserRole = UserRole.Doctor,
                Amka = "19486750237",
                PatientHistory = "",
                Notes = "",
                Location = "Καβάλα",
                Username = "doc18",
                Password = "docpass18",
                ProfilePicture = "/uploads/doctor18.jpg"
            },
            // 🧑‍⚕️ Αλέξανδρος Παπαδόπουλος (Doctor)
            new User {
                FirstName = "Αλέξανδρος",
                LastName = "Παπαδόπουλος",
                UserRole = UserRole.Doctor,
                Amka = "20835647192",
                PatientHistory = "",
                Notes = "",
                Location = "Ξάνθη",
                Username = "doc19",
                Password = "docpass19",
                ProfilePicture = "/uploads/doctor19.jpg"
            },
             // 🧑‍⚕️ Γρηγόρης Δούκας (Doctor)
            new User {
                FirstName = "Γρηγόρης",
                LastName = "Δούκας",
                UserRole = UserRole.Doctor,
                Amka = "78315926047",
                PatientHistory = "",
                Notes = "",
                Location = "Κοζάνη",
                Username = "doc20",
                Password = "docpass20",
                ProfilePicture = "/uploads/doctor20.jpg"
            },
            // 🧑‍⚕️ Αχιλλέας Βογιατζής (Doctor)
            new User {
                FirstName = "Αχιλλέας",
                LastName = "Βογιατζής",
                UserRole = UserRole.Doctor,
                Amka = "46183920518",
                PatientHistory = "",
                Notes = "",
                Location = "Άρτα",
                Username = "doc21",
                Password = "docpass21",
                ProfilePicture = "/uploads/doctor21.jpg"
            },
            // 🧑‍⚕️ Παναγιώτης Γαλανάκης (Doctor)
            new User {
                FirstName = "Παναγιώτης",
                LastName = "Γαλανάκης",
                UserRole = UserRole.Doctor,
                Amka = "54867210398",
                PatientHistory = "",
                Notes = "",
                Location = "Κατερίνη",
                Username = "doc22",
                Password = "docpass22",
                ProfilePicture = "/uploads/doctor22.jpg"
            },
            // 🧑‍⚕️ Βασίλης Χειμωνάς (Doctor)
            new User {
                FirstName = "Βασίλης",
                LastName = "Χειμωνάς",
                UserRole = UserRole.Doctor,
                Amka = "20937184516",
                PatientHistory = "",
                Notes = "",
                Location = "Σέρρες",
                Username = "doc23",
                Password = "docpass23",
                ProfilePicture = "/uploads/doctor23.jpg"
            },
            // 🧑‍⚕️ Ισίδωρος Λάμπρου (Doctor)
            new User {
                FirstName = "Ισίδωρος",
                LastName = "Λάμπρου",
                UserRole = UserRole.Doctor,
                Amka = "64328917023",
                PatientHistory = "",
                Notes = "",
                Location = "Λαμία",
                Username = "doc24",
                Password = "docpass24",
                ProfilePicture = "/uploads/doctor24.jpg"
            },
            // 🧑‍⚕️ Σταμάτης Αλεξανδρής (Doctor)
            new User {
                FirstName = "Σταμάτης",
                LastName = "Αλεξανδρής",
                UserRole = UserRole.Doctor,
                Amka = "73248915764",
                PatientHistory = "",
                Notes = "",
                Location = "Χίος",
                Username = "doc25",
                Password = "docpass25",
                ProfilePicture = "/uploads/doctor25.jpg"
            },
            // 🧑‍⚕️ Νικόλαος Παπανικολάου (Doctor)
            new User {
                FirstName = "Νικόλαος",
                LastName = "Παπανικολάου",
                UserRole = UserRole.Doctor,
                Amka = "12038479165",
                PatientHistory = "",
                Notes = "",
                Location = "Σπάρτη",
                Username = "doc26",
                Password = "docpass26",
                ProfilePicture = "/uploads/doctor26.jpg"
            },

            // 🧍‍♀️ Ελπίδα Μαντά (Patient)
            new User {
                FirstName = "Ελπίδα",
                LastName = "Μαντά",
                UserRole = UserRole.Patient,
                Amka = "17293084765",
                Sex = Sex.Female,
                Age = 49,
                PatientHistory = "Χρόνια δυσκοιλιότητα και ήπια αφυδάτωση.",
                Notes = "Συνιστάται αλλαγή διατροφής με περισσότερες ίνες και υγρά.",
                Location = "Πειραιάς",
                Username = "pat01",
                Password = "patpass01",
                ProfilePicture = "/uploads/patient01.jpg"
            },
            // 🧍‍♂️ Θεόφιλος Κοτσακάς (Patient)
            new User {
                FirstName = "Θεόφιλος",
                LastName = "Κοτσακάς",
                UserRole = UserRole.Patient,
                Amka = "64382710938",
                Sex = Sex.Male,
                Age = 44,
                PatientHistory = "Τραυματισμός στο γόνατο.",
                Notes = "Ανάγκη για φυσικοθεραπεία 4 εβδομάδων.",
                Location = "Αθήνα",
                Username = "pat02",
                Password = "patpass02",
                ProfilePicture = "/uploads/patient02.jpg"
            },
             // 🧍‍♀️ Αγγελική Καλαμπόκα (Patient)
            new User {
                FirstName = "Αγγελική",
                LastName = "Καλαμπόκα",
                UserRole = UserRole.Patient,
                Amka = "83947261035",
                Sex = Sex.Female,
                Age = 19,
                PatientHistory = "Συχνές ημικρανίες και ναυτία.",
                Notes = "Συνταγογράφηση φαρμακευτικής αγωγής.",
                Location = "Πάτρα",
                Username = "pat03",
                Password = "patpass03",
                ProfilePicture = "/uploads/patient03.jpg"
            },
            // 🧍‍♂️ Λευτέρης Στεφάνου (Patient)
            new User {
                FirstName = "Λευτέρης",
                LastName = "Στεφάνου",
                UserRole = UserRole.Patient,
                Amka = "29837460138",
                Sex = Sex.Male,
                Age = 25,
                PatientHistory = "Ελαφρύ άσθμα κατά την άνοιξη.",
                Notes = "Προληπτική αγωγή με αντιισταμινικά.",
                Location = "Βόλος",
                Username = "pat04",
                Password = "patpass04",
                ProfilePicture = "/uploads/patient04.jpg"
            },
            // 🧍‍♀️ Ιουλία Ζαφειροπούλου (Patient)
            new User {
                FirstName = "Ιουλία",
                LastName = "Ζαφειροπούλου",
                UserRole = UserRole.Patient,
                Amka = "72390157482",
                Sex = Sex.Female,
                Age = 63,
                PatientHistory = "Διαβήτης τύπου 2.",
                Notes = "Ανασκόπηση διατροφής και φαρμακευτικής αγωγής.",
                Location = "Κατερίνη",
                Username = "pat05",
                Password = "patpass05",
                ProfilePicture = "/uploads/patient05.jpg"
            },
            // 🧍‍♂️ Σταύρος Καραμανλής (Patient)
            new User {
                FirstName = "Σταύρος",
                LastName = "Καραμανλής",
                UserRole = UserRole.Patient,
                Amka = "21937854061",
                Sex = Sex.Male,
                Age = 71,
                PatientHistory = "Μέτρια υπέρταση.",
                Notes = "Συνέχιση παρακολούθησης κάθε τρίμηνο.",
                Location = "Χαλκίδα",
                Username = "pat06",
                Password = "patpass06",
                ProfilePicture = "/uploads/patient06.jpg"
            },
            };
            foreach (var user in users)
            {
                var existingUser = context.Users.FirstOrDefault(u => u.Amka.Trim() == user.Amka.Trim());

                if (existingUser == null)
                {
                    context.Users.Add(user);
                }
                else
                {
                    
                    existingUser.FirstName = user.FirstName;
                    existingUser.LastName = user.LastName;
                    existingUser.UserRole = user.UserRole;
                    existingUser.PatientHistory = user.PatientHistory;
                    existingUser.Notes = user.Notes;
                    existingUser.Location = user.Location;
                    existingUser.Username = user.Username;
                    existingUser.Password = user.Password;
                    existingUser.ProfilePicture = user.ProfilePicture;
                }
            }
            try
            {
                context.SaveChanges();
                Console.WriteLine("Users added or updated in the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving users: {ex.Message}");
            }
        }
    }
}
