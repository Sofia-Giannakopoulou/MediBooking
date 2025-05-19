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
                // 🧍‍♀️ Elpida Mada (Patient)
            new User {
                FirstName = "Elpida",
                LastName = "Mada",
                UserRole = UserRole.Patient,
                Amka = "17293084765",
                Sex = Sex.Female,
                Age = 49,
                PatientHistory = "Chronic constipation and mild dehydration.",
                Notes = "A dietary change with increased fiber and fluids is recommended.",
                Location = "Eleftheriou Venizelou 21, Kallithea 176 75",
                Username = "pat01",
                Password = "patpass01",
                ProfilePicture = "/uploads/pat8.jpg",
                Email = "elpidamad39@hotmail.com"
            },
            // 🧍‍♂️ Theofilos Kotsakas (Patient)
            new User {
                FirstName = "Theofilos",
                LastName = "Kotsakas",
                UserRole = UserRole.Patient,
                Amka = "64382710938",
                Sex = Sex.Male,
                Age = 44,
                PatientHistory = "Knee injury.",
                Notes = "Four weeks of physiotherapy required.",
                Location = "Timoleontos Vassou 7, Psychiko 154 52",
                Username = "pat02",
                Password = "patpass02",
                ProfilePicture = "/uploads/patient02.jpg",
                Email = "theokotsakas18@gmail.com"
            },
             // 🧍‍♀️ Aggeliki Kalaboka (Patient)
            new User {
                FirstName = "Aggeliki",
                LastName = "Kalaboka",
                UserRole = UserRole.Patient,
                Amka = "83947261035",
                Sex = Sex.Female,
                Age = 19,
                PatientHistory = "Frequent migraines and nausea.",
                Notes = "Medication prescribed.",
                Location = "Ermou 58, Athens 105 53",
                Username = "pat03",
                Password = "patpass03",
                ProfilePicture = "/uploads/patient03.jpg",
                Email = "angelkalabibi@hotmail.com"
            },
            // 🧍‍♂️ Leuteris Stefanou (Patient)
            new User {
                FirstName = "Leuteris",
                LastName = "Stefanou",
                UserRole = UserRole.Patient,
                Amka = "29837460138",
                Sex = Sex.Male,
                Age = 25,
                PatientHistory = "Mild asthma during spring.",
                Notes = "Preventive treatment with antihistamines.",
                Location = "Zakynthou 8, Kaisariani 161 22",
                Username = "pat04",
                Password = "patpass04",
                ProfilePicture = "/uploads/patient04.jpg",
                Email = "lefostef9@gmail.com"
            },
            // 🧍‍♀️ Ioulia Zefeiropoulou (Patient)
            new User {
                FirstName = "Ioulia",
                LastName = "Zafeiropoulou",
                UserRole = UserRole.Patient,
                Amka = "72390157482",
                Sex = Sex.Female,
                Age = 63,
                PatientHistory = "Type 2 diabetes.",
                Notes = "Review of diet and medication.",
                Location = "Armodiou 9, Nea Chalkidona 143 44",
                Username = "pat05",
                Password = "patpass05",
                ProfilePicture = "/uploads/patient05.jpg",
                Email = "yulizafeiropoulou@gmail.com"
            },
            // 🧍‍♂️ Kwstas Kokkaras (Patient)
            new User {
                FirstName = "Kwstas",
                LastName = "Kokkaras",
                UserRole = UserRole.Patient,
                Amka = "21937854061",
                Sex = Sex.Male,
                Age = 34,
                PatientHistory = "Elevated cholesterol levels. Monitoring lipid profile regularly.\r\nSeasonal allergy symptoms during spring.",
                Notes = "Use of antihistamines.",
                Location = "Kavalas 14, Moschato 183 43",
                Username = "pat06",
                Password = "patpass06",
                ProfilePicture = "/uploads/patient06.jpg",
                Email = "satsokok91@hotmail.com"
            },
                // 🧍‍♂️ George Fotopoulos (Patient)
                new User
                {
                    FirstName      = "George",
                    LastName       = "Fotopoulos",
                    UserRole       = UserRole.Patient,
                    Amka           = "12051980321",
                    Sex            = Sex.Male,
                    Age            = 33,
                    PatientHistory = "Routine cardiovascular health check, no significant findings. Mild hypertension.\r\n\r\n",
                    Notes          = "Underwent a general medical check-up. No immediate issues reported. Regular monitoring of blood pressure and cholesterol every six months is recommended.",
                    Location       = "Paradeisou 3, Marousi 151 25",
                    Username       = "user01",
                    Password       = "pass01",
                    ProfilePicture = "/uploads/Grande.jpg",
                    Email = "geofotopoulos9@hotmail.com"
                },

                // 🧍‍♂️ Jason Sofianopoulos (Patient)
                new User
                {
                    FirstName      = "Jason",
                    LastName       = "Sofianopoulos",
                    UserRole       = UserRole.Patient,
                    Amka           = "01012000459",
                    Sex            = Sex.Other,
                    Age            = 32,
                    PatientHistory = "Diet for reducing body fat. Successful weight loss of 8 kilograms over the past 5 months.",
                    Notes          = "Currently in the maintenance phase of the nutritional plan. Has responded positively.",
                    Location       = "Faistou 12, Kifisia 145 61",
                    Username       = "user04",
                    Password       = "pass04",
                    ProfilePicture = "/uploads/Jason.jpg",
                    Email = "jasounisifu12@hotmail.com"
                },

                // 🧍‍♂️ Nikos Vasileiou (Patient)
                new User
                {
                    FirstName      = "Nikos",
                    LastName       = "Vasileiou",
                    UserRole       = UserRole.Patient,
                    Amka           = "22071976236",
                    Sex            = Sex.Male,
                    Age            = 32,
                    PatientHistory = "Accident involving a knife in 2023 – emergency surgical reattachment of the right thumb.Recovery is ongoing.\r\n\r\n",
                    Notes          = "Thumb reimplantation.Currently in the healing phase.Manual labor should be avoided. Follow-up in 6 weeks is recommended.\r\n",
                    Location       = "Solomou 23, Drosia 145 72",
                    Username       = "user06",
                    Password       = "pass06",
                    ProfilePicture = "/uploads/Vasileiou.jpg",
                    Email = "deathmetalforlife32@gmail.com"
                },

                // 🧍‍♀️ Thomai Sofianopoulou (Patient)
                new User
                {
                    FirstName      = "Thomai",
                    LastName       = "Sofianopoulou",
                    UserRole       = UserRole.Patient,
                    Amka           = "05082001333",
                    Sex            = Sex.Female,
                    Age            = 29,
                    PatientHistory = "Frequent headaches and cervical syndrome. Initial diagnosis suggests migraines. Awaiting neurological examination.",
                    Notes          = "Frequent headaches — possible migraine. Brain MRI and symptom diary have been recommended. Temporary treatment with painkillers has been prescribed.",
                    Location       = "Faistou 12, Kifisia 145 61",
                    Username       = "user07",
                    Password       = "pass07",
                    ProfilePicture = "/uploads/Thomi.jpg",
                    Email = "thomigiasounena1@gmail.com"
                },

                // 🧍‍♀️ Marilia Rodi (Patient)
                new User
                {
                    FirstName      = "Marilia",
                    LastName       = "Rodi",
                    UserRole       = UserRole.Patient,
                    Amka           = "30041993392",
                    Sex            = Sex.Female,
                    Age            = 28,
                    PatientHistory = "HPV infection (genital warts). Currently under treatment with topical medications. Psychological distress due to the diagnosis.",
                    Notes          = "Ongoing treatment for HPV genital warts. Regular gynecological monitoring is recommended. Psychological support has been suggested due to anxiety.",
                    Location       = "37 Rue de la Bûcherie, 75005 Paris, France",
                    Username       = "user08",
                    Password       = "pass08",
                    ProfilePicture = "/uploads/Marilia.jpg",
                    Email = "fashioico69@hotmail.com"
                },

                // 🧍‍♂️ Paris Tafas (Patient)
                new User
                {
                    FirstName      = "Paris",
                    LastName       = "Tafas",
                    UserRole       = UserRole.Patient,
                    Amka           = "08031984406",
                    Sex            = Sex.Male,
                    Age            = 32,
                    PatientHistory = "Fall injury. Musculoskeletal pain without fracture. History of smoking one pack per day.",
                    Notes          = "No fractures detected. Anti-inflammatory medication and physiotherapy for 2 weeks. Follow-up gait assessment in 10 days.",
                    Location       = "Lewf. Pentelis 71, Brilissia 152 38",
                    Username       = "user09",
                    Password       = "pass09",
                    ProfilePicture = "/uploads/Paris.jpg",
                    Email = "paristaf80@gmail.com"
                },

                // 🧍‍♂️ Panagiwtis Fotopoulos (Patient)
                new User
                {
                    FirstName      = "Panagiwtis",
                    LastName       = "Fotopoulos",
                    UserRole       = UserRole.Patient,
                    Amka           = "17072010328",
                    Sex            = Sex.Male,
                    Age            = 29,
                    PatientHistory = "Excessive drowsiness during evening hours. Presence of nystagmus and intermittent loss of awareness. Possible narcolepsy.",
                    Notes          = "Episodes of drowsiness reported after 9:00 PM. Suspected mild form of narcolepsy. Polysomnography is recommended.",
                    Location       = "Paradeisou 3, Marousi 151 25",
                    Username       = "user10",
                    Password       = "pass10",
                    ProfilePicture = "/uploads/MikrosF.jpg",
                    Email = "smallfotopoulos29@gmail.com"
                },

                // 🧍‍♂️ Aro Giannakopoulos (Patient)
                new User
                {
                    FirstName      = "Aro",
                    LastName       = "Giannakopoulos",
                    UserRole       = UserRole.Patient,
                    Amka           = "10121992275",
                    Sex            = Sex.Male,
                    Age            = 13,
                    PatientHistory = "Chronic stomach issues, allergic dermatitis, arthropathy.\r\nDiagnosis: benign prostatic hyperplasia.\r\nPositive progress regarding stomach problems. Prostate enlargement persists.",
                    Notes          = " Medication continues. PSA recheck is required in 2 months.",
                    Location       = "Mixali Karaoli 17, Nea Xalkidona 143 43",
                    Username       = "user11",
                    Password       = "pass11",
                    ProfilePicture = "/uploads/aro.jpg",
                    Email = "aroyian17@gmail.com"
                },

                // 🧑‍⚕️ Anastasios Xatzis (Doctor)
                new User
                {
                    FirstName = "Anastasios",
                    LastName = "Xatzis",
                    UserRole = UserRole.Doctor,
                    Amka = "19508297028",
                    Sex  = Sex.Male,
                    DoctorSpecialty = DoctorSpecialty.Cardiology,
                    PatientHistory = "",
                    Notes = "",
                    Location = "Veikou 10, Galatsi 111 46",
                    Username = "doc01",
                    Password = "docpass01",
                    ProfilePicture = "/uploads/doctor01.jpg",
                    Email = "anastasios_xatzis@gmail.com"
                },
                // 🧑‍⚕️ Dionysus Karagiannis (Doctor)
                new User {
                    FirstName = "Dionysus",
                    LastName = "Karagiannis",
                    UserRole = UserRole.Doctor,
                    Amka = "75394181238",
                    Sex  = Sex.Male,
                    DoctorSpecialty = DoctorSpecialty.Dermatology,
                    PatientHistory = "",
                    Notes = "",
                    Location = "Kifisou 45, Peristeri 121 31",
                    Username = "doc02",
                    Password = "docpass02",
                    ProfilePicture = "/uploads/doctor02.jpg",
                    Email = "dionysus_karagiannis@gmail.com"
                },
                // 🧑‍⚕️ Nektarios Anagnostou (Doctor)
                new User {
                    FirstName = "Nektarios",
                    LastName = "Anagnostou",
                    UserRole = UserRole.Doctor,
                    Amka = "25974910038",
                    Sex  = Sex.Male,
                    DoctorSpecialty = DoctorSpecialty.Pathology,
                    PatientHistory = "",
                    Notes = "",
                    Location = "Vrilissia 7, Vrilissia 152 35",
                    Username = "doc03",
                    Password = "docpass03",
                    ProfilePicture = "/uploads/doctor03.jpg",
                    Email = "nektarios_anagnostou@gmail.com"
                },
                // 🧑‍⚕️ Themistocles Vlaxos (Doctor)
                new User {
                    FirstName = "Themistocles",
                    LastName = "Vlaxos",
                    UserRole = UserRole.Doctor,
                    Amka = "03265048647",
                    Sex  = Sex.Male,
                    DoctorSpecialty = DoctorSpecialty.Urology,
                    PatientHistory = "",
                    Notes = "",
                    Location = "Ermou 23, Monastiraki 105 63",
                    Username = "doc04",
                    Password = "docpass04",
                    ProfilePicture = "/uploads/doctor04.jpg",
                    Email = "themistocles_vlaxos@gmail.com"
                },
                // 🧑‍⚕️ Polukarpos Lemonis (Doctor)
                new User {
                FirstName = "Polukarpos",
                LastName = "Lemonis",
                UserRole = UserRole.Doctor,
                Amka = "67153270491",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.Gastroenterology,
                PatientHistory = "",
                Notes = "",
                Location = "Amfitheas 15, Marousi 151 25",
                Username = "doc05",
                Password = "docpass05",
                ProfilePicture = "/uploads/doctor05.jpg",
                Email = "polukarpos_lemonis@gmail.com"
            },
                // 🧑‍⚕️ Efstratios Georgakopoulos (Doctor)
            new User {
                FirstName = "Efstratios",
                LastName = "Georgakopoulos",
                UserRole = UserRole.Doctor,
                Amka = "97024816302",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.Rheumatology,
                PatientHistory = "",
                Notes = "",
                Location = "Tatoiou 3, Kifisia 145 61",
                Username = "doc06",
                Password = "docpass06",
                ProfilePicture = "/uploads/doctor06.jpg",
                Email = "efstratios_georgakopoulos@gmail.com"
            },
            // 🧑‍⚕️ Ioannis Makris (Doctor)
            new User {
                FirstName = "Ioannis",
                LastName = "Makris",
                UserRole = UserRole.Doctor,
                Amka = "64328710973",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.GeneralSurgery,
                PatientHistory = "",
                Notes = "",
                Location = "Papagou 8, Papagou 156 69",
                Username = "doc07",
                Password = "docpass07",
                ProfilePicture = "/uploads/doctor07.jpg",
                Email = "ioannis_makris@hotmail.com"
            },
             // 🧑‍⚕️ Theodore Sitaras (Doctor)
            new User {
                FirstName = "Theodore",
                LastName = "Sitaras",
                UserRole = UserRole.Doctor,
                Amka = "20489173521",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.Endocrinology,
                PatientHistory = "",
                Notes = "",
                Location = "Dervenion 5, Nea Filadelfeia 143 43",
                Username = "doc08",
                Password = "docpass08",
                ProfilePicture = "/uploads/doctor08.jpg",
                Email = "theodore_sitaras@hotmail.com"
            },
            // 🧑‍⚕️ Chris Spanoudis (Doctor)
            new User {
                FirstName = "Chris",
                LastName = "Spanoudis",
                UserRole = UserRole.Doctor,
                Amka = "95140782361",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.InfectiousDisease,
                PatientHistory = "",
                Notes = "",
                Location = "Lykavittou 21, Kolonaki 106 75",
                Username = "doc09",
                Password = "docpass09",
                ProfilePicture = "/uploads/doctor09.jpg",
                Email = "chris_spanoudis@gmail.com"
            },
             // 🧑‍⚕️ Gerasimos Sideris (Doctor)
            new User {
                FirstName = "Gerasimos",
                LastName = "Sideris",
                UserRole = UserRole.Doctor,
                Amka = "47318269041",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.Hematology,
                PatientHistory = "",
                Notes = "",
                Location = "Mesogeion 108, Ambelokipi 115 26",
                Username = "doc10",
                Password = "docpass10",
                ProfilePicture = "/uploads/doctor10.jpg",
                Email = "gerasimos_sideris@hotmail.com"
            },
            // 🧑‍⚕️ Stilianos Fragoulis (Doctor)
            new User {
                FirstName = "Stilianos",
                LastName = "Fragoulis",
                UserRole = UserRole.Doctor,
                Amka = "38592741603",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.CardiothoracicSurgery,
                PatientHistory = "",
                Notes = "",
                Location = "Kanari 9, Glyfada 166 74",
                Username = "doc11",
                Password = "docpass11",
                ProfilePicture = "/uploads/doctor11.jpg",
                Email = "stilianos_fragoulis@gmail.com"
            },
            // 🧑‍⚕️ Aristidis Bouras (Doctor)
            new User {
                FirstName = "Aristidis",
                LastName = "Bouras",
                UserRole = UserRole.Doctor,
                Amka = "40298713562",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.AllergyAndImmunology,
                PatientHistory = "",
                Notes = "",
                Location = "Grigoriou Lampraki 35, Nea Smyrni 171 21",
                Username = "doc12",
                Password = "docpass12",
                ProfilePicture = "/uploads/doctor12.jpg",
                Email = "aristidis_bouras@hotmail.com"
            },
            // 🧑‍⚕️ Evagelos Diamantis (Doctor)
            new User {
                FirstName = "Evagelos",
                LastName = "Diamantis",
                UserRole = UserRole.Doctor,
                Amka = "61472830570",
                Sex  = Sex.Male,
                DoctorSpecialty = DoctorSpecialty.Neurology,
                PatientHistory = "",
                Notes = "",
                Location = "Ippokratous 14, Kallithea 176 74",
                Username = "doc13",
                Password = "docpass13",
                ProfilePicture = "/uploads/doctor13.jpg",
                Email = "evagelos_diamantis@gmail.com"
            },
            // 👩⚕️ Anna Terzopoulou (Doctor)
            new User {
                FirstName = "Anna",
                LastName = "Terzopoulou",
                UserRole = UserRole.Doctor,
                Amka = "98423106743",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.ReproductiveEndocrinology,
                PatientHistory = "",
                Notes = "",
                Location = "Aristotelous 40, Palaio Faliro 175 63",
                Username = "doc14",
                Password = "docpass14",
                ProfilePicture = "/uploads/doctor14.jpg",
                Email = "anna_terzopoulou@hotmail.com"
            },
             // 👩⚕️ Panagiwta Zerva (Doctor)
            new User {
                FirstName = "Panagiwta",
                LastName = "Zerva",
                UserRole = UserRole.Doctor,
                Amka = "12085749613",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Pulmonology,
                PatientHistory = "",
                Notes = "",
                Location = "Omonia 18, Athens 104 32",
                Username = "doc15",
                Password = "docpass15",
                ProfilePicture = "/uploads/doctor15.jpg",
                Email = "panagiwta_zerva@gmail.com"
            },
            // 👩⚕️ Loukia Karatza (Doctor)
            new User {
                FirstName = "Loukia",
                LastName = "Karatza",
                UserRole = UserRole.Doctor,
                Amka = "30842150986",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.OphthalmicSurgery,
                PatientHistory = "",
                Notes = "",
                Location = "Petrou Ralli 22, Tavros 177 78",
                Username = "doc16",
                Password = "docpass16",
                ProfilePicture = "/uploads/doctor16.jpg",
                Email = "loukia_karatza@hotmail.com"
            },
            // 👩⚕️ Antonia Nikolopoulou (Doctor)
            new User {
                FirstName = "Antonia",
                LastName = "Nikolopoulou",
                UserRole = UserRole.Doctor,
                Amka = "71820469370",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Otolaryngology,
                PatientHistory = "",
                Notes = "",
                Location = "Filadelfias 77, Nea Ionia 142 31",
                Username = "doc17",
                Password = "docpass17",
                ProfilePicture = "/uploads/doctor17.jpg",
                Email = "antonia_nikolopoulou@gmail.com"
            },
            // 👩⚕️ Xristina Galani (Doctor)
            new User {
                FirstName = "Xristina",
                LastName = "Galani",
                UserRole = UserRole.Doctor,
                Amka = "19486750237",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.OrthopedicSurgery,
                PatientHistory = "",
                Notes = "",
                Location = "Kavalas 6, Moschato 183 44",
                Username = "doc18",
                Password = "docpass18",
                ProfilePicture = "/uploads/doctor18.jpg",
                Email = "xristina_galani@hotmail.com"
            },
            // 👩⚕️ Aleksandra Papadopoulou (Doctor)
            new User {
                FirstName = "Aleksandra",
                LastName = "Papadopoulou",
                UserRole = UserRole.Doctor,
                Amka = "20835647192",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Neurology,
                PatientHistory = "",
                Notes = "",
                Location = "Kleanthous 12, Chalandri 152 32",
                Username = "doc19",
                Password = "docpass19",
                ProfilePicture = "/uploads/doctor19.jpg",
                Email = "aleksandra_papadopoulou@gmail.com"
            },
             // 👩⚕️ Grigoria Douka (Doctor)
            new User {
                FirstName = "Grigoria",
                LastName = "Douka",
                UserRole = UserRole.Doctor,
                Amka = "78315926047",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Oncology,
                PatientHistory = "",
                Notes = "",
                Location = "Panepistimiou 60, Athens 106 79",
                Username = "doc20",
                Password = "docpass20",
                ProfilePicture = "/uploads/doctor20.jpg",
                Email = "grigoria_douka@hotmail.com"
            },
            // 👩⚕️ Eleni Vogiatzi (Doctor)
            new User {
                FirstName = "Eleni",
                LastName = "Vogiatzi",
                UserRole = UserRole.Doctor,
                Amka = "46183920518",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.AerospaceMedicine,
                PatientHistory = "",
                Notes = "",
                Location = "Ippokratous 55, Psychiko 154 51",
                Username = "doc21",
                Password = "docpass21",
                ProfilePicture = "/uploads/doctor21.jpg",
                Email = "eleni_vogiatzi@gmail.com"
            },
            // 👩⚕️ Adriana Douka (Doctor)
            new User {
                FirstName = "Adriana",
                LastName = "Douka",
                UserRole = UserRole.Doctor,
                Amka = "54867210398",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Neuropsychiatry,
                PatientHistory = "",
                Notes = "",
                Location = "Sygrou 199, Nea Smyrni 171 21",
                Username = "doc22",
                Password = "docpass22",
                ProfilePicture = "/uploads/doctor22.jpg",
                Email = "adrianna_douka@hotmail.com"
            },
            // 👩⚕️ Basiliki Ximona (Doctor)
            new User {
                FirstName = "Vasiliki",
                LastName = "Ximona",
                UserRole = UserRole.Doctor,
                Amka = "20937184516",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Nephrology,
                PatientHistory = "",
                Notes = "",
                Location = "Veikou 29, Galatsi 111 46",
                Username = "doc23",
                Password = "docpass23",
                ProfilePicture = "/uploads/doctor23.jpg",
                Email = "vasiliki_ximona@gmail.com"
            },
            // 👩⚕️ Isidwra Labrou (Doctor)
            new User {
                FirstName = "Isidwra",
                LastName = "Labrou",
                UserRole = UserRole.Doctor,
                Amka = "64328917023",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.OphthalmicSurgery,
                PatientHistory = "",
                Notes = "",
                Location = "Kifisias 70, Marousi 151 25",
                Username = "doc24",
                Password = "docpass24",
                ProfilePicture = "/uploads/doctor24.jpg",
                Email = "isidwra_labrou@hotmail.com"
            },
            // 👩⚕️ Stamatia Aleksandri (Doctor)
            new User {
                FirstName = "Stamatia",
                LastName = "Aleksandri",
                UserRole = UserRole.Doctor,
                Amka = "73248915764",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Pathology,
                PatientHistory = "",
                Notes = "",
                Location = "Iraklidon 23, Nea Smyrni 171 23",
                Username = "doc25",
                Password = "docpass25",
                ProfilePicture = "/uploads/doctor25.jpg",
                Email = "stamatia_aleksandri@gmail.com"
            },
            // 👩⚕️ Nikoleta Papanikolaou (Doctor)
            new User {
                FirstName = "Nikoleta",
                LastName = "Papanikolaou",
                UserRole = UserRole.Doctor,
                Amka = "12038479165",
                Sex  = Sex.Female,
                DoctorSpecialty = DoctorSpecialty.Psychiatry,
                PatientHistory = "",
                Notes = "",
                Location = "Chatzichristou 8, Nea Filadelfeia 143 42",
                Username = "doc26",
                Password = "docpass26",
                ProfilePicture = "/uploads/doctor26.jpg",
                Email = "nikoleta_papanikolaou@hotmail.com"
            },
            // 🧑‍⚕️ Kostas Kalogeropoulos (Doctor)
                new User
                {
                    FirstName      = "Kostas",
                    LastName       = "Kalogeropoulos",
                    UserRole       = UserRole.Doctor,
                    Amka           = "14101985213",
                    Sex            = Sex.Male,
                    DoctorSpecialty = DoctorSpecialty.Cardiology,
                    PatientHistory = "",
                    Notes          = "",
                    Location       = "Ilisiwn 19, Kifisia 145 64",
                    Username       = "user05",
                    Password       = "pass05",
                    ProfilePicture = "/uploads/Kataigidas.jpg",
                    Email = "kostas_kalogeropoulos@gmail.com"
                },
                
                // 🧑‍⚕️ Rwmanos Kefalidis (Doctor)
                new User
                {
                    FirstName      = "Rwmanos",
                    LastName       = "Kefalidis",
                    UserRole       = UserRole.Doctor,
                    Sex            = Sex.Male,
                    DoctorSpecialty = DoctorSpecialty.Psychiatry,
                    Amka           = "10121991275",
                    PatientHistory = "",
                    Notes          = "",
                    Location       = "plac Zamkowy 4, 00-277 Warszawa, Poland",
                    Username       = "user12",
                    Password       = "pass12",
                    ProfilePicture = "/uploads/rwmanos.jpg",
                    Email = "romanos_kefalidis@gmail.com"
                },
            // 🧍‍♀️ Sofia Giannakopoulou (Admin)
                new User
                {
                    FirstName      = "Sofia",
                    LastName       = "Giannakopoulou",
                    Sex            = Sex.Female,
                    Age            = 33,
                    UserRole       = UserRole.Admin,
                    Location       = "Mixaki Karaoli 17, Nea Xalkidona 14343",
                    Username       = "user02",
                    Password       = "pass02",
                    ProfilePicture = "/uploads/Sofia.jpg",
                    Email = "sofia_yian@hotmail.com"
                },

                // 🧍‍♂️ Thomas Benhafsi (Admin)
                new User
                {
                    FirstName      = "Thomas",
                    LastName       = "Benhafsi",
                    Sex            = Sex.Male,
                    Age            = 32,
                    UserRole       = UserRole.Admin,
                    Location       = "Brioulwn 28, Peuki 151 21",
                    Username       = "user03",
                    Password       = "pass03",
                    ProfilePicture = "/uploads/thomas.jpg",
                    Email = "brutaldante1337@hotmail.com"
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
                    existingUser.Age = user.Age;
                    existingUser.Email = user.Email;
                    existingUser.Sex = user.Sex;
                    existingUser.DoctorSpecialty = user.DoctorSpecialty;
                    
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
