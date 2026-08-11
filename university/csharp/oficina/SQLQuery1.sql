CREATE DATABASE OficinaDB;
GO

USE OficinaDB;
GO

CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Telefone NVARCHAR(20),
    Email NVARCHAR(100),
    NIF NVARCHAR(20)
);
GO

CREATE TABLE FolhasObra (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL,
    DataEntrada DATE NOT NULL,
    Matricula NVARCHAR(20) NOT NULL,
    Marca NVARCHAR(50),
    Modelo NVARCHAR(50),
    Km INT,
    ProblemaDescrito NVARCHAR(500),
    ServicosRealizados NVARCHAR(500),
    Estado NVARCHAR(50),
    ValorTotal DECIMAL(10,2),

    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id)
);
GO

-- Dados de exemplo

SET IDENTITY_INSERT Clientes ON;

INSERT INTO Clientes (Id, Nome, Telefone, Email, NIF) VALUES
(1047, N'Tio Patinhas',      '912345678', 'tio.patinhas@email.pt',      '234567890'),
(2156, N'Pato Donald',       '923456789', 'pato.donald@email.pt',       '345678901'),
(3289, N'Zé Carioca',        '934567890', NULL,                         '456789012'),
(4012, N'Margarida',         '945678901', 'margarida@email.pt',         NULL),
(5187, N'Pateta',            '956789012', 'pateta@email.pt',            '567890123'),
(6023, N'Pluto',             '967890123', 'pluto@email.pt',             '678901234'),
(7154, N'Mickey',            '918901234', 'mickey@email.pt',            '789012345'),
(8231, N'Minnie',            '929012345', NULL,                         '890123456'),
(9045, N'Huguinho',          '930123456', 'huguinho@email.pt',          '901234567'),
(10187, N'Zezinho',           '931234567', 'zezinho@email.pt',           '112345678'),
(11234, N'Luizinho',          '932345678', 'luizinho@email.pt',          '123456780'),
(12456, N'Simba',             '933456789', 'simba@email.pt',             '134567891'),
(13789, N'Timon',             '934567801', NULL,                         '145678902'),
(14012, N'Pumba',             '935678912', 'pumba@email.pt',             '156789013'),
(15234, N'Woody',             '936789023', 'woody@email.pt',             '167890124'),
(16891, N'Buzz Lightyear',    '937890134', 'buzz@email.pt',              '178901235'),
(17023, N'Olaf',              '938901245', NULL,                         '189012346'),
(18456, N'Elsa',              '939012356', 'elsa@email.pt',              '190123457'),
(19234, N'Anna',              '910123467', 'anna@email.pt',              '201234568'),
(20156, N'Mowgli',            '911234578', 'mowgli@email.pt',            '212345679'),
(21345, N'Bambi',             '912345689', NULL,                         '223456780'),
(22890, N'Dumbo',             '913456790', 'dumbo@email.pt',             '234567891');

SET IDENTITY_INSERT Clientes OFF;
DBCC CHECKIDENT ('Clientes', RESEED, 24000);
GO

INSERT INTO FolhasObra (ClienteId, DataEntrada, Matricula, Marca, Modelo, Km, ProblemaDescrito, ServicosRealizados, Estado, ValorTotal) VALUES
-- Tio Patinhas (1047)
(1047, '2026-06-10', '12-AB-34', 'Renault',     'Clio',     154000, 'Faz barulho ao travar',               'Substituição pastilhas travão frente',    'Concluída',      85.50),
(1047, '2026-06-20', '45-CD-67', 'Volkswagen',  'Golf',      98000, 'Luz do motor acesa',                  'Diagnóstico + limpeza filtro ar',         'Em Reparação',  120.00),
(1047, '2026-03-15', '12-AB-34', 'Renault',     'Clio',     150000, 'Revisão anual',                       'Mudança óleo, filtros e velas',           'Concluída',     145.00),

-- Pato Donald (2156)
(2156, '2026-06-15', '78-EF-90', 'Peugeot',     '208',      67000, 'Ar condicionado não arrefece',        NULL,                                      'Aberta',          0.00),
(2156, '2026-05-22', '78-EF-90', 'Peugeot',     '208',      66500, 'Revisão periódica',                   'Mudança óleo e filtro',                   'Concluída',      95.00),
(2156, '2026-01-10', '78-EF-90', 'Peugeot',     '208',      62000, 'Pneus gastos',                        'Substituição 4 pneus',                   'Concluída',     320.00),

-- Zé Carioca (3289)
(3289, '2026-06-25', '23-GH-45', 'BMW',         '320d',    210000, 'Embraiagem a patinar',                'Substituição kit embraiagem',             'Em Reparação',  450.00),
(3289, '2026-04-08', '23-GH-45', 'BMW',         '320d',    205000, 'Inspeção B — travões',                'Discos e pastilhas traseiras',           'Concluída',     280.00),

-- Margarida (4012)
(4012, '2026-06-28', '56-IJ-78', 'Toyota',      'Yaris',    42000, 'Pneu furado',                         'Reparação + equilíbrio roda',             'Aberta',         35.00),

-- Pateta (5187)
(5187, '2026-06-05', '89-KL-01', 'Ford',        'Focus',   125000, 'Volante treme em velocidade',         'Alinhamento e balanceamento',             'Concluída',      65.00),
(5187, '2026-02-20', '89-KL-01', 'Ford',        'Focus',   120000, 'Bateria fraca',                       'Substituição bateria 70Ah',              'Concluída',     110.00),

-- Pluto (6023)
(6023, '2026-06-18', '34-MN-56', 'Citroën',     'C3',       88000, 'Vidro da frente rachado',             'Substituição para-brisas',               'Em Reparação',  180.00),
(6023, '2026-05-01', '34-MN-56', 'Citroën',     'C3',       87000, 'Barulho na suspensão',                'Substituição amortecedores frente',      'Concluída',     220.00),

-- Mickey (7154)
(7154, '2026-06-22', '67-OP-78', 'Mercedes-Benz','A180',    55000, 'Serviço de manutenção',               'Revisão completa concessionário',          'Concluída',     350.00),
(7154, '2026-06-26', '90-QR-12', 'Audi',        'A3',       72000, 'Sensor de estacionamento avariado', 'Diagnóstico elétrico',                   'Aberta',          0.00),

-- Minnie (8231)
(8231, '2026-06-12', '11-ST-34', 'Fiat',        'Panda',    95000, 'Overheating',                         'Substituição termostato e líquido',        'Concluída',      75.00),

-- Huguinho (9045)
(9045, '2026-06-24', '22-UV-56', 'Seat',        'Ibiza',   110000, 'Escape com furo',                     'Soldadura e reforço silencioso',         'Em Reparação',   90.00),
(9045, '2026-03-30', '22-UV-56', 'Seat',        'Ibiza',   108000, 'Correia de distribuição',             'Substituição kit distribuição',          'Concluída',     380.00),

-- Zezinho (10187)
(10187, '2026-06-27', '33-WX-78', 'Hyundai',    'i20',      34000, 'Primeira revisão',                    'Mudança óleo e filtro',                  'Concluída',      80.00),

-- Luizinho (11234)
(11234, '2026-06-14', '44-YZ-90', 'Nissan',     'Qashqai', 145000, 'Turbo com fumo azul',                'Reparação turbo',                         'Em Reparação',  890.00),
(11234, '2026-05-05', '44-YZ-90', 'Nissan',     'Qashqai', 144000, 'Filtro de particulas',               'Limpeza FAP',                             'Concluída',     150.00),

-- Simba (12456)
(12456, '2026-06-19', '55-AA-11', 'Opel',       'Corsa',    76000, 'Luzes interiores não funcionam',     'Reparação circuito elétrico',             'Concluída',      45.00),

-- Timon (13789)
(13789, '2026-06-23', '66-BB-22', 'Skoda',      'Octavia', 168000, 'Caixa automática patina',            'Diagnóstico caixa velocidades',           'Aberta',          0.00),

-- Pumba (14012)
(14012, '2026-06-16', '77-CC-33', 'Renault',    'Megane',   92000, 'Fecho central falha',          'Substituição motor fecho porta',          'Concluída',      55.00),
(14012, '2026-04-25', '77-CC-33', 'Renault',    'Megane',   91000, 'Ar condicionado a perder gás',       'Carregamento gás A/C',                    'Concluída',      70.00),

-- Woody (15234)
(15234, '2026-06-21', '88-DD-44', 'Volkswagen', 'Polo',     58000, 'Risco na porta',                      'Reparação e pintura local',               'Em Reparação',  200.00),

-- Buzz Lightyear (16891)
(16891, '2026-06-11', '99-EE-55', 'Peugeot',    '3008',     48000, 'Sistema start-stop não funciona',    'Substituição sensor BMS',                 'Concluída',     130.00),

-- Olaf (17023)
(17023, '2026-06-29', '10-FF-66', 'Toyota',     'Corolla',  31000, 'Risco no para-choques',          NULL,                                      'Aberta',          0.00),

-- Elsa (18456)
(18456, '2026-06-08', '21-GG-77', 'Dacia',      'Sandero', 102000, 'Travão de mão não segura',           'Ajuste cabos travão mão',                 'Concluída',      40.00),
(18456, '2026-02-14', '21-GG-77', 'Dacia',      'Sandero', 100000, 'Amortecedores traseiros',            'Substituição par amortecedores',         'Concluída',     160.00),

-- Anna (19234)
(19234, '2026-06-17', '32-HH-88', 'Ford',       'Fiesta',  134000, 'Alternador com ruído',               'Substituição alternador',                 'Concluída',     195.00),

-- Mowgli (20156)
(20156, '2026-06-13', '43-II-99', 'Mini',       'Cooper',   65000, 'Direção assistida pesada',           'Verificação bomba direção',               'Em Reparação',  175.00),

-- Bambi (21345)
(21345, '2026-06-07', '54-JJ-00', 'Honda',      'Civic',   178000, 'Consumo de óleo elevado',            'Verificação segmentos e anéis',           'Em Reparação',  320.00),
(21345, '2026-05-18', '54-JJ-00', 'Honda',      'Civic',   177000, 'Velas',            'Substituição velas',                      'Concluída',      85.00),

-- Dumbo (22890)
(22890, '2026-06-26', '65-KK-11', 'Kia',        'Sportage', 29000, 'Barulho nos travões',                'Limpeza e lubrificação pinças',           'Concluída',      60.00),
(22890, '2026-06-01', '65-KK-11', 'Kia',        'Sportage', 28000, 'Revisão dos 30.000 km',             'Revisão completa',                        'Concluída',     210.00);
GO
