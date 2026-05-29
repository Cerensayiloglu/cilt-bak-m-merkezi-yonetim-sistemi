DROP DATABASE IF EXISTS bakım_merkezi;
create database bakım_merkezi;
use bakım_merkezi;
create table kullanıcı(
kullanıcı_id int primary KEY AUTO_INCREMENT ,
ad varchar(100) not null,
soyad varchar(100) not null,
telefon varchar(15) ,
e_mail varchar(50),
cinsiyet varchar(50) check(cinsiyet in('kadın','erkek'))
);
create table uzman(
uzman_id int primary KEY  AUTO_INCREMENT,
u_ad varchar(100) not null,
u_soyad varchar(100) not null,
uzmanlık varchar(50)
);
create table cilt_analizi(
Analiz_id int primary KEY AUTO_INCREMENT ,
uzman_id int,
kullanıcı_id int,
analiz_tarihi date,
cilt_tipi varchar(10),
cilt_skoru int,
FOREIGN KEY (kullanıcı_id) REFERENCES kullanıcı(kullanıcı_id),
FOREIGN KEY (uzman_id) REFERENCES uzman(uzman_id)
);
create table cilt_problemi(
problem_id int primary KEY AUTO_INCREMENT ,
analiz_id int,
problem_adi varchar(50),
FOREIGN KEY(analiz_id) REFERENCES cilt_analizi(analiz_id)
);
create table bakim_planı(
plan_id int primary KEY AUTO_INCREMENT ,
analiz_id int,
plan_acıklama varchar(50),
FOREIGN KEY(analiz_id) REFERENCES cilt_analizi(analiz_id)

);
create table seans(
seans_id int primary KEY AUTO_INCREMENT ,
plan_id int,
seans_tarihi date not null,
FOREIGN KEY(plan_id) REFERENCES bakim_planı(plan_id)
);
create table urun(
urun_id int primary KEY AUTO_INCREMENT ,
urun_adi varchar(50),
stok int
);
create table ex_urun(
id int primary KEY AUTO_INCREMENT ,
urun_id int,
seans_id int,
miktar int,
FOREIGN KEY (urun_id) REFERENCES urun(urun_id),
FOREIGN KEY (seans_id) REFERENCES seans(seans_id)
);
create table siparis(
siparis_id  int primary KEY AUTO_INCREMENT ,
kullanıcı_id int,
tutar int,
odeme_turu varchar(50),
FOREIGN KEY (kullanıcı_id) REFERENCES kullanıcı(kullanıcı_id)
);
DELIMITER //
CREATE FUNCTION fn_toplam_odeme
(
   p_kullanici_id INT
)
RETURNS INT
DETERMINISTIC
BEGIN

   DECLARE toplam int;

   SELECT SUM(tutar)
   INTO toplam
   FROM siparis
   WHERE kullanıcı_id = p_kullanici_id;

   RETURN IFNULL(toplam,0);

END//
DELIMITER ;

DELIMITER //
create function fn_problem_bulma(
p_analiz_id int
)
RETURNS INT
DETERMINISTIC
BEGIN
   DECLARE toplam INT;

   SELECT COUNT(*)
   INTO toplam
   FROM cilt_problemi
   WHERE analiz_id = p_analiz_id;

   RETURN toplam;

END//
DELIMITER ;
DELIMITER //
create TRIGGER trg_bakım_planı_olustur
AFTER INSERT
on cilt_analizi
FOR EACH ROW 
BEGIN
   INSERT INTO bakim_planı
   (analiz_id, plan_acıklama)
   VALUES
   (NEW.analiz_id,'Standart cilt bakım planı');

END //

DELIMITER ;
DELIMITER //
CREATE TRIGGER trg_stok_azalt
AFTER INSERT
ON ex_urun
FOR EACH ROW
BEGIN

   UPDATE urun
   SET stok = stok - NEW.miktar
   WHERE urun_id = NEW.urun_id;

END //
DELIMITER ;
INSERT INTO kullanıcı(ad,soyad,telefon,e_mail,cinsiyet)
values
('ela','yılmaz','05456554518','elayılmaz@gmail.com','kadın');
INSERT INTO uzman(u_ad,u_soyad,uzmanlık)
values
('buse','demir','cilt bakımı');
INSERT INTO cilt_analizi
(uzman_id,kullanıcı_id,analiz_tarihi,cilt_tipi,cilt_skoru)
VALUES
(1,1,'2026-08-01','karma',70);
INSERT INTO cilt_problemi(analiz_id,problem_adi)
values
(1,'akne'),
(1,'kuruluk'),
(1,'leke');
INSERT INTO siparis(kullanıcı_id,tutar,odeme_turu)
values
(1,500,'kart'),
(1,500,'nakit');

INSERT INTO seans(plan_id,seans_tarihi)
values
(1,'2026-08-12');
INSERT INTO urun(urun_adi,stok)
values
('c vitamini serumu',10),
('nemlendirici krem',15),
('kil maskesi',20),
('peeling serum',10),
('pirinç toniği',10),
('temizleyici jel',25),
('güneş kremi',15);
INSERT INTO ex_urun
(urun_id,seans_id,miktar)
VALUES
(1,1,3);

INSERT INTO bakım_merkezi.uzman(u_ad,u_soyad,uzmanlık)
values
('ahmet','Aktas','cilt bakımı');
INSERT INTO bakım_merkezi.uzman(u_ad,u_soyad,uzmanlık)
values
('betül','tas','leke uzmanı');












