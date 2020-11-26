-- Table: crypto_data.quote_data

-- DROP TABLE crypto_data.quote_data;

CREATE TABLE postgres.quote_data
(
    id bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    symbol character varying(128) COLLATE pg_catalog."default",
    CONSTRAINT quote_data_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE postgres.quote_data
    OWNER to postgres;