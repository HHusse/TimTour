INSERT INTO [TimTourDB].[dbo].[Restaurants] 
            ([Name], [Type], [Address], [PhoneNumber], [WebSiteURL])
VALUES 
            ('Curtea Berarilor', 1, 'Strada Proclamația de la Timișoara 7, Timișoara 300054', '0726743789', 'https://www.facebook.com/pg/curteaberii.timisoara/posts/?ref=page_internal'),
            ('Le Monelline', 2, 'Strada episcop Pacha Augustin NR 5 Piata Unirii, Timisoara 300055', '+40 744 104 846', 'https://www.lemonelline.com'),
            ('Anturaj', 1, 'B-dul Vasile Parvan 5, Timisoara 300223', '+40 799 300 800', 'https://web.facebook.com/anturaj.tm/?_rdc=1&_rdr'),
            ('Cinque Terre', 2, 'Strada Blaga Lucian 1 Piața Libertății, Timisoara 300001', '+40 731 634 687', 'https://cinque-terre-timisoara.business.site/?utm_source=gmb&utm_medium=referral'),
            ('Enjoy Piaţa Unirii', 3, 'Piata Unirii Nr. 9, Timisoara 300085', '+40 733 380 001', ''),
            ('Restaurant Pizzerie Casa Thalia', 4, 'Str. Holdelor 4, Timisoara 300270', '+40 751 270 311', 'https://www.casathalia.ro'),
            ('Restaurant Casa del Sole', 1, 'Str. Romulus Nr.12 Boutique Hotel Casa del Sole, Timisoara 300238', '+40 770 346 886', 'https://restaurant.casadelsole.ro'),
            ('Fresh Kebab', 4, 'Piata Victoriei 3, Timisoara 300030', '+40 256 222 596', 'https://web.facebook.com/FreshKebabTimisoara/?_rdc=1&_rdr'),
            ('Kos Greek Taverna', 4, 'Strada Gheorghe Lazar Nr. 8 Pietonala, Timisoara 300080', '+40 738 225 388', 'https://web.facebook.com/KosGreekTaverna/?_rdc=1&_rdr'),
            ('Biofresh Restaurant Vegetarian and Vegan', 3, 'str. Francesco Grisellini nr. 2 near Centrul Comercial Bega, Timisoara 300054', '+40 724 637 374', 'http://biofreshtm.ro');


INSERT INTO [TimTourDB].[dbo].[Museums] 
            ([Name], [Address], [WebSiteURL])
VALUES 
            ('Muzeul de Arta', 'Piața Unirii 1, Timișoara 300085', 'https://muzeuldeartatm.ro'),
            ('Muzeul Satului Banatean', 'Strada Avram Imbroane 1, Timișoara 300136', 'http://muzeulsatuluibanatean.ro/'),
            ('Muzeul de Transport Public Corneliu Miklosi', 'Bulevardul Take Ionescu 83, Timișoara 300303', 'https://web.facebook.com/profile.php?id=100069624110005&locale=ro_RO&_rdc=1&_rdr'),
            ('Muzeul Catedralei Mitropolitane', 'Timisoara, Bulevardul Regele Ferdinand I', 'https://mitropolia-banatului.ro/colectia-de-arta-bisericeasca-veche/');


INSERT INTO [TimTourDB].[dbo].[Hotels] 
            ([Name], [Stars], [Address], [PhoneNumber], [WebSiteURL])
VALUES 
            ('NH Timisoara', 4, 'Strada Pestalozzi Iohan Heinrich 1/a Fabric, Timisoara 300115', '00 1 212-245-5462', 'https://www.nh-hotels.com/en/booking/step1-rates?fini=26%2F11%2F2023&fout=27%2F11%2F2023&nadults1=2&nchilds1=0&refid=5d9e3371-4988-4add-8fb6-7372b9074c09&hotelId=ROTM.TIMIS&utm_medium=metasearch-listings&utm_source=tripadvisor&utm_campaign=metasearch-listings_tripadvisor&utm_term=english-us_hotelpage_desktop-ba&utm_content=114430588&campid=8436102'),
            ('Boutique Hotel Casa del Sole', 4, 'Strada Romulus Nr. 12, Timisoara 300238', '+40 356 45 77 71', 'https://hotel.casadelsole.ro'),
            ('Mercure Timisoara', 4, 'Blv Cetatii Nr 10, Timisoara 300397', '0372 617 879', ''),
            ('Tresor Le Palais', 5, 'Str. Radu Tudoran Nr.18 (intr. din Aleea Ghirodei, Timisoara 3000000', '0256 228 754', 'https://tresorlepalais.ro'),
            ('ibis Timisoara City Center Hotel', 3, 'Calea Circumvalatiunii 8-10A Entrance Coriolan Brediceanu 16, Timisoara 300012', '0256 701 141', ''),
            ('Del Corso Hotel', 4, 'Calea Bogdanestilor Nr. 18, Timisoara 300392', '0256 289 289', 'https://hoteldelcorso.ro/ro'),
            ('Hotel Galaxy', 3, 'Berlin 26, Timisoara 300571', '0356 100 760', 'https://hotelgalaxy.ro'),
            ('Hotel President', 3, 'Strada Lipatti Dinu nr. 25, Timisoara 300391', '0256 293 797', 'https://hotelpresident.ro'),
            ('Ramina Hotel & Restaurant', 3, 'Strada Strandului 12/A, Timisoara 300310', '0256 272 732', 'http://www.restaurant-ramina.ro'),
            ('Hotel Silva', 3, 'Bulevardul Babes Victor 25, Timisoara 300594', '0740 238 231', '');


INSERT INTO [TimTourDB].[dbo].[Bars] 
            ([Name], [Address], [PhoneNumber], [WebSiteURL])
VALUES 
            ('Storia', 'Strada Eugeniu de Savoya nr 11, Timisoara 300085', '0751 068 981', 'https://www.facebook.com/storiacoffee'),
            ('Symphony Cafe', 'Strada Alba Iulia nr. 2, Timisoara 300077', '0724 521 527', 'https://www.facebook.com/SymphonyCafe'),
            ('Fratelli Lounge & Club', 'Bulevardul Coposu Corneliu 1, Timisoara 300552', '0722 122 123', 'https://fratelli.ro/fratelli-timisoara/'),
            ('Aethernativ', 'Strada Marasesti 14, Ap. 3, Timisoara 300077', '0724 012 364', ''),
            ('The 80s Pub', 'Str Aries, nr 19 Casa Tineretului, Timisoara 300579', '0731 692 051', 'https://www.facebook.com/The80sPub/'),
            ('TapRoom', 'Piata Traian nr 6, Timisoara 300102', '0720 008 732', 'https://www.facebook.com/taproomtm/'),
            ('Bibliotheka', ' Strada Eugeniu de Savoya 24, Timișoara 300181', '0256 200 555', 'https://bibliotheka.ro'),
            ('Coco', 'Strada Eugeniu de Savoya 1 G, Timisoara 300055', '0722 740 717', 'https://www.facebook.com/COCOTimisoara/?locale=ro_RO'),
            ('Manufactura', 'Splaiul Vladimirescu Tudor nr. 9, Timisoara 300195', '0722 892 356', 'https://www.facebook.com/manufactura.timisoara/');

INSERT INTO [TimTourDB].[dbo].[Events] 
            ([Name], [Type], [Date], [Time], [Location], [LocationAddress])
VALUES 
            ('Your Electro Way Dance Battle Timișoara', 4, '2023-11-18', '13:00', 'FABER', 'Splaiul Peneș Curcanul 4-5, Timișoara'),
            ('HAMLET', 1 ,'2023-11-30', '19:00', 'Teatrul Național "Mihai Eminescu"', 'Str. Mărăşeşti nr. 2, 300086 Timişoara'),
            ('Familia Addams', 2, '2023-11-27', '19:00', 'OPERA NAȚIONALĂ ROMÂNĂ din TIMIȘOARA', 'Str. Mărășești nr. 2, 300080 Timișoara'),
            ('Nebun dupa tine', 2, '2023-11-23', '19:00', 'OPERA NAȚIONALĂ ROMÂNĂ din TIMIȘOARA', 'Str. Mărășești nr. 2, 300080 Timișoara'),
            ('M.G.L - The Goat is Back', 3, '2023-11-24', '19:00', 'Heaven', 'Strada Ripensia, Nr. 40, Timișoara'),
            ('Stand-up Comedy cu Dan Badea - RAU VEGAN', 4, '2023-11-21', '18:00', 'Sala Capitol Timisoara', 'Bd. Constantin Diaconovici Loga, 2, Timisoara'),
            ('Bărbatul perfect defect', 4, '2023-11-20', '19:00', 'Sala Capitol Timisoara', 'Bd. Constantin Diaconovici Loga, 2, Timisoara');