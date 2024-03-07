CREATE TABLE mInpsector (
    NO INT IDENTITY(1,1) PRIMARY KEY,
    차종 VARCHAR(500),
    ALC VARCHAR(500) UNIQUE not null,
    품번 VARCHAR(500) not null,
    사양 VARCHAR(500) not null

);


insert into mInpsector(차종,ALC,품번,사양)
values('Mx5pe','1k223','kkke2','123092pr'),('Mx5peb','1dfk223','kddkke2','234092pr'),('zzc5pe','12f223','22ke2','1212pr'),('Mx35pe','1k2123','kkke12','123092pdfr')