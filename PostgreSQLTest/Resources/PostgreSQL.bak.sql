PGDMP     )    :    	        
    x            sandbox    13.1    13.1     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16449    sandbox    DATABASE     k   CREATE DATABASE sandbox WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE sandbox;
                postgres    false            �          0    16451 
   quote_data 
   TABLE DATA           5   COPY crypto_data.quote_data (id, symbol) FROM stdin;
    crypto_data          postgres    false    201   �       �           0    0    quote_data_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('crypto_data.quote_data_id_seq', 2, true);
          crypto_data          postgres    false    202            �      x�3�t
q�2���1z\\\ ��     