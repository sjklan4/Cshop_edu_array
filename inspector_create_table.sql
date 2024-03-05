CREATE TABLE mInpsector (
    NO INT IDENTITY(1,1) PRIMARY KEY,
    차종 VARCHAR(500),
    ALC VARCHAR(500) UNIQUE not null,
    품번 VARCHAR(500) not null,
    사양 VARCHAR(500) not null

);