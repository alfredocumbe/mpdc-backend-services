CREATE DATABASE db_mpdc_assets;

CREATE TABLE assets (
  id                  INT           NOT NULL IDENTITY PRIMARY KEY,
  name                VARCHAR(100)  NOT NULL,
  manufacture         VARCHAR(100),
  model               VARCHAR(100),
  capacity            VARCHAR(55),
  category            VARCHAR(55),
  location            VARCHAR(200),
  usage_status        VARCHAR(55),
  description         VARCHAR(100),
  maintenance_status  VARCHAR(55)
);

CREATE TABLE warranties (
  id                    INT           NOT NULL    IDENTITY    PRIMARY KEY,
  dealer                VARCHAR(100) NOT NULL,
  serial_number         BIGINT NOT NULL,
  date_of_purchasing    DATETIME,
  cost_of_purchasing    FLOAT,
  current_value         FLOAT,
  exiparation_date      DATETIME,
  asset_id INT,
  FOREIGN KEY (asset_id) REFERENCES assets(id)
);


CREATE TABLE asset_descriptions (
  id                INT           NOT NULL    IDENTITY    PRIMARY KEY,
  description       VARCHAR(100) NOT NULL,
  asset_id INT,
  FOREIGN KEY (asset_id) REFERENCES assets(id)
);

CREATE TABLE asset_images (
  id                INT           NOT NULL    IDENTITY    PRIMARY KEY,
  file_name       VARCHAR(100) NOT NULL,
  file_location   VARCHAR(200) NOT NULL,
  url VARCHAR(200) NOT NULL,
  asset_id INT,
  FOREIGN KEY (asset_id) REFERENCES assets(id)
);
