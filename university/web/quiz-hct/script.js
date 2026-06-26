/**
 * Quiz de Escolha Múltipla
 * Adiciona novas perguntas ao array QUESTIONS abaixo.
 */

const QUESTIONS = [
    // Tema 1: Helénico (Grécia Antiga e Astronomia Clássica)
    {
        question: "Quais as grandes civilizações hidráulicas que influenciaram a cultura grega?",
        options: ["Fenícia e Pérsia", "Roma e Cartago", "Egipto e Mesopotâmia", "Civilização do Vale do Indo e China"],
        answer: "Egipto e Mesopotâmia"
    },
    {
        question: "Quais eram os elementos defendidos por Empédocles e o 5º elemento introduzido por Aristóteles?",
        options: ["Metal, Madeira, Fogo, Terra / 5º: Água", "Terra, Ar, Água, Fogo / 5º: Éter", "Fogo, Água, Vento, Luz / 5º: Escuridão", "Terra, Vento, Plasma, Fogo / 5º: Cosmos"],
        answer: "Terra, Ar, Água, Fogo / 5º: Éter"
    },
    {
        question: "Quem era conhecido como o \"estagirita\" e que escola fundou?",
        options: ["Platão, que fundou a Academia de Atenas.", "Sócrates, que fundou a Ágora.", "Aristóteles, que fundou o Liceu.", "Ptolomeu, que fundou a Biblioteca de Alexandria."],
        answer: "Aristóteles, que fundou o Liceu."
    },
    {
        question: "Como se caracterizava o Universo de Aristóteles?",
        options: ["Infinito, heliocêntrico e dividido em três regiões.", "Finito, geocêntrico e imóvel, dividido em região supralunar (éter) e sublunar (4 elementos).", "Esférico, centrado no Sol e composto inteiramente por éter.", "Geocêntrico, mas com os planetas a orbitarem elipticamente ao redor da Terra."],
        answer: "Finito, geocêntrico e imóvel, dividido em região supralunar (éter) e sublunar (4 elementos)."
    },
    {
        question: "Qual era o mecanismo utilizado por Ptolomeu para explicar o movimento planetário sem quebrar o primado dos movimentos circulares?",
        options: ["Translação, rotação e libração.", "Gravidade universal e elipses.", "Epiciclos, deferentes e equantos.", "Esferas de cristal concêntricas perfeitamente alinhadas."],
        answer: "Epiciclos, deferentes e equantos."
    },
    {
        question: "Que mudança fundamental introduziu o Universo de Copérnico?",
        options: ["O modelo heliocêntrico, colocando o Sol imóvel no centro do universo finito.", "A ideia de que o universo é infinito e sem um centro definido.", "O facto de que todas as estrelas orbitam a Terra em conjunto com o Sol.", "A descoberta das órbitas elípticas de todos os planetas."],
        answer: "O modelo heliocêntrico, colocando o Sol imóvel no centro do universo finito."
    },
    {
        question: "Quem foi o primeiro astrónomo a sugerir que a Terra orbitava em torno do Sol?",
        options: ["Galileu Galilei", "Johannes Kepler", "Heron de Alexandria", "Aristarco de Samos"],
        answer: "Aristarco de Samos"
    },
    {
        question: "Onde foi encontrado o mecanismo de Antikythera?",
        options: ["Enterrado nas ruínas da Biblioteca de Alexandria.", "Submerso ao largo da costa da ilha grega de Anticítera em 1901.", "Numa escavação arqueológica no Monte Olimpo.", "Numa antiga embarcação romana no rio Nilo."],
        answer: "Submerso ao largo da costa da ilha grega de Anticítera em 1901."
    },
    {
        question: "Quais são os dois tipos de construção mais importantes da civilização grega?",
        options: ["Pirâmides e aquedutos.", "Anfiteatros e balneários.", "Templos e teatros.", "Zigurates e fóruns."],
        answer: "Templos e teatros."
    },
    {
        question: "Quais são as máquinas simples de Heron de Alexandria?",
        options: ["Engrenagem, alavanca, roldana (polia), cunha, mola e roda (com eixo).", "Catapulta, arco, balista, roldana e rampa.", "Parafuso sem fim, moinho de água, eolípila e guindaste.", "Alavanca, plano inclinado, roda dentada e pêndulo."],
        answer: "Engrenagem, alavanca, roldana (polia), cunha, mola e roda (com eixo)."
    },
    {
        question: "Quem iniciou a 1.ª grande revolução científica e qual o paradigma instituído?",
        options: ["Isaac Newton com a Gravidade Universal.", "Nicolau Copérnico com o Heliocentrismo.", "Galileu Galilei com o Método Experimental.", "Aristóteles com o Geocentrismo."],
        answer: "Nicolau Copérnico com o Heliocentrismo."
    },
    {
        question: "Como era o Universo de Platão e que escola fundou?",
        options: ["Heliocêntrico, ordenado pelo Caos; fundou o Liceu.", "Esférico e geocêntrico, ordenado por um \"Demiurgo\" com base em proporções matemáticas; fundou a Academia de Atenas.", "Infinito e sem forma geométrica; fundou a Escola de Estagira.", "Constituído apenas pelo mundo das ideias sem representação física; fundou o Panteão."],
        answer: "Esférico e geocêntrico, ordenado por um \"Demiurgo\" com base em proporções matemáticas; fundou a Academia de Atenas."
    },
    // Tema 9: Arquitetura de Von Neumann e História da Computação
    {
        question: "Qual é o nome de um antigo instrumento de cálculo comum a inúmeras civilizações isoladas?",
        options: ["Astrolábio", "Pascalina", "Ábaco", "Régua de Cálculo"],
        answer: "Ábaco"
    },
    {
        question: "Qual o documento que deu origem ao computador EDVAC e onde foi construído?",
        options: ["\"The Universal Machine\", no Bletchley Park.", "\"First Draft of a Report on the EDVAC\", na Universidade da Pensilvânia.", "\"Computing Machinery and Intelligence\", na RAND Corporation.", "\"The Analytical Engine Concept\", na Universidade de Manchester."],
        answer: "\"First Draft of a Report on the EDVAC\", na Universidade da Pensilvânia."
    },
    {
        question: "Qual foi a primeira máquina de cálculo eficaz, inventada em 1642?",
        options: ["Máquina das Diferenças", "Calculadora dentada de Leibniz", "Pascalina", "Mecanismo de Antikythera"],
        answer: "Pascalina"
    },
    {
        question: "Que máquinas foram projetadas por Charles Babbage?",
        options: ["Colossus e Enigma", "Máquina das Diferenças e Máquina Analítica", "Bombe e Heath Robinson", "ENIAC e EDVAC"],
        answer: "Máquina das Diferenças e Máquina Analítica"
    },
    {
        question: "Como era feita a entrada de dados na máquina analítica e quem foi a sua programadora?",
        options: ["Válvulas de vácuo; programada por Grace Hopper.", "Fitas magnéticas; programada por Alan Turing.", "Teclado mecânico; programada por Blaise Pascal.", "Cartões perfurados; programada por Ada Lovelace."],
        answer: "Cartões perfurados; programada por Ada Lovelace."
    },
    {
        question: "Porque é a máquina analítica considerada a precursora do computador moderno?",
        options: ["Porque foi a primeira a usar transístores em vez de válvulas.", "Porque o seu design incluía uma unidade de processamento, memória e sistemas de entrada/saída.", "Porque era capaz de comunicar com outras máquinas através de telégrafo.", "Porque funcionava a energia elétrica, dispensando o vapor."],
        answer: "Porque o seu design incluía uma unidade de processamento, memória e sistemas de entrada/saída."
    },
    {
        question: "Em qual das máquinas de Babbage se baseou o engenheiro sueco Pehr Scheutz?",
        options: ["Máquina Analítica", "Pascalina", "Máquina das Diferenças", "Colossus"],
        answer: "Máquina das Diferenças"
    },
    {
        question: "A quem se deve a lógica que inspirou a lógica computacional e a criação da álgebra booleana, respetivamente?",
        options: ["Platão e Alan Turing", "Aristóteles e George Boole", "Sócrates e John von Neumann", "Pitágoras e Charles Babbage"],
        answer: "Aristóteles e George Boole"
    },
    {
        question: "Qual foi a máquina conceptual imaginada por Alan Turing?",
        options: ["Máquina Universal (Máquina de Turing)", "Máquina Analítica", "JOHNIAC", "Máquina das Diferenças"],
        answer: "Máquina Universal (Máquina de Turing)"
    },
    {
        question: "Que computadores foram criados por Turing em Bletchley Park e qual o seu objetivo?",
        options: ["ENIAC, EDVAC e UNIVAC; para calcular trajetórias balísticas.", "Bombe, Heath Robinson e Colossus; para decifrar os códigos das máquinas Enigma e Lorentz.", "Atlas, Johniac e Memex; para simular redes neuronais.", "Mac, Lisa e Apple I; para uso pessoal."],
        answer: "Bombe, Heath Robinson e Colossus; para decifrar os códigos das máquinas Enigma e Lorentz."
    },
    {
        question: "Qual é considerado o primeiro computador da primeira geração (eletrónico de propósito geral)?",
        options: ["Colossus", "UNIVAC I", "EDVAC", "ENIAC"],
        answer: "ENIAC"
    },
    {
        question: "Qual era a finalidade original do ENIAC e quando ficou pronto?",
        options: ["Decifrar códigos nazis; pronto em 1943.", "Controlar missões espaciais; pronto em 1957.", "Calcular tabelas complexas de tiro de artilharia militar; pronto em 1946.", "Processar dados do censo populacional; pronto em 1950."],
        answer: "Calcular tabelas complexas de tiro de artilharia militar; pronto em 1946."
    },
    {
        question: "Que empresa construiu o JOHNIAC e qual era a sua arquitetura?",
        options: ["IBM; Arquitetura de Turing.", "RAND Corporation; Arquitetura de Von Neumann (IAS).", "Apple; Arquitetura RISC.", "Microsoft; Arquitetura x86."],
        answer: "RAND Corporation; Arquitetura de Von Neumann (IAS)."
    },
    {
        question: "Onde foi desenvolvido o computador Atlas e a que geração pertencia?",
        options: ["Estados Unidos; 1ª geração (válvulas de vácuo).", "Alemanha; 3ª geração (microprocessadores).", "Reino Unido; 2ª geração (transístores e memória virtual).", "Japão; 2ª geração (circuitos integrados)."],
        answer: "Reino Unido; 2ª geração (transístores e memória virtual)."
    },
    // Tema 11: MicroInformática e Multimédia
    {
        question: "Quem criou a válvula díodo e quais os seus elementos?",
        options: ["Lee de Forest; Cátodo, Ânodo e Grelha.", "John Fleming; Cátodo e Ânodo.", "Alan Turing; Emissor e Recetor.", "John von Neumann; Positivo e Negativo."],
        answer: "John Fleming; Cátodo e Ânodo."
    },
    {
        question: "Quem criou a válvula tríodo e que elemento adicionou?",
        options: ["Lee de Forest; adicionou a grelha (grelha mediadora).", "John Fleming; adicionou o ânodo.", "Charles Babbage; adicionou o moinho.", "Blaise Pascal; adicionou o filamento."],
        answer: "Lee de Forest; adicionou a grelha (grelha mediadora)."
    },
    {
        question: "Como se chamava o 1.º compilador, quem o criou e para que computador?",
        options: ["B-1; Ada Lovelace; Máquina Analítica.", "C++; Bjarne Stroustrup; ENIAC.", "A-0; Grace Hopper; UNIVAC I.", "Fortran; John Backus; EDVAC."],
        answer: "A-0; Grace Hopper; UNIVAC I."
    },
    {
        question: "Quais são dois elementos obrigatórios numa apresentação multimédia?",
        options: ["Texto e Animação", "Vídeo e Gráficos", "Hiperligações e Software", "Som e Imagem"],
        answer: "Som e Imagem"
    },
    {
        question: "Que equipamento da Apple é considerado o ponto de partida da multimédia (1984)?",
        options: ["Apple II", "iPod", "Macintosh", "iPad"],
        answer: "Macintosh"
    },
    {
        question: "Qual é a principal finalidade dos scanners?",
        options: ["Imprimir documentos digitais em papel fotográfico.", "Converter sinais analógicos em dados digitais (bitmap em memória).", "Gravar ficheiros de áudio em CD-ROM.", "Aumentar a velocidade de processamento da CPU."],
        answer: "Converter sinais analógicos em dados digitais (bitmap em memória)."
    },
    {
        question: "Quem desenvolveu o sistema de gravação do CD-ROM (1984) e qual a sua tecnologia?",
        options: ["IBM e Microsoft; tecnologia magnética.", "Apple e Intel; tecnologia de transístores.", "Philips e Sony; tecnologia de armazenamento e leitura ótica (laser).", "RAND Corporation e NCSA; tecnologia de microchips."],
        answer: "Philips e Sony; tecnologia de armazenamento e leitura ótica (laser)."
    },
    {
        question: "Quais são dois sistemas baseados no sistema operativo UNIX?",
        options: ["Windows e MS-DOS", "Linux e macOS", "Android e iOS", "OS/2 e CP/M"],
        answer: "Linux e macOS"
    },
    {
        question: "Quem inventou o Rato (1968)?",
        options: ["Steve Jobs", "Bill Gates", "Douglas Engelbart", "Tim Berners-Lee"],
        answer: "Douglas Engelbart"
    },
    // Tema 13: Internet e Hipertexto
    {
        question: "O que era o projeto \"Memex\" e quem o idealizou em 1945?",
        options: ["Um computador militar desenhado por Alan Turing.", "A primeira rede de satélites criada pela ARPA.", "O primeiro software de edição de imagem de Ted Nelson.", "Um sistema teórico eletrónico de acesso rápido a textos digitalizados, idealizado por Vannevar Bush."],
        answer: "Um sistema teórico eletrónico de acesso rápido a textos digitalizados, idealizado por Vannevar Bush."
    },
    {
        question: "Quem criou a palavra \"Hipertexto\" e como é definido?",
        options: ["Tim Berners-Lee; textos longos e lineares.", "Ted Nelson; texto estruturado de forma não-linear, ligado por nós e links.", "Steve Crocker; a linguagem base da Arpanet.", "Andrew Lippman; texto embebido em ficheiros de vídeo."],
        answer: "Ted Nelson; texto estruturado de forma não-linear, ligado por nós e links."
    },
    {
        question: "Qual era a ambição do projeto \"Xanadu\", criado por Ted Nelson?",
        options: ["Criar um jogo interativo com gráficos 3D.", "Estabelecer uma rede de defesa militar intercontinental.", "Desenvolver uma base de dados global interligando informação através de hipermédia à escala mundial.", "Construir o primeiro computador com arquitetura quântica."],
        answer: "Desenvolver uma base de dados global interligando informação através de hipermédia à escala mundial."
    },
    {
        question: "Quem criou a WWW (World Wide Web) em 1989/1990?",
        options: ["Bill Gates", "Tim Berners-Lee", "Vannevar Bush", "Douglas Engelbart"],
        answer: "Tim Berners-Lee"
    },
    {
        question: "O que foi a Arpanet e porque foi originalmente desenhada?",
        options: ["A primeira rede social, desenhada para comunicação universitária.", "Uma rede militar com tecnologia packet-switching, desenhada para manter comunicações operacionais em caso de ataque nuclear.", "Um sistema de cabo de fibra ótica para transmitir o projeto Memex.", "Uma intranet comercial desenvolvida pela IBM na década de 80."],
        answer: "Uma rede militar com tecnologia packet-switching, desenhada para manter comunicações operacionais em caso de ataque nuclear."
    },
    {
        question: "Porque é que o protocolo NCP foi substituído pelo TCP-IP?",
        options: ["Porque o NCP era demasiado lento para transmitir vídeo.", "Porque o NCP só funcionava em sistemas Windows.", "Porque o NCP operava apenas numa rede isolada, e o TCP-IP suportava o internetworking à escala global.", "Porque o TCP-IP foi uma exigência da criação da World Wide Web de Tim Berners-Lee."],
        answer: "Porque o NCP operava apenas numa rede isolada, e o TCP-IP suportava o internetworking à escala global."
    },
    {
        question: "Qual foi o primeiro Browser web a funcionar de forma popular e visual no Windows (1993)?",
        options: ["Internet Explorer", "Netscape Navigator", "Google Chrome", "Mosaic"],
        answer: "Mosaic"
    },
    {
        question: "Quem criou o \"Aspen Movie Map\" em 1978?",
        options: ["Ted Nelson (Projeto Xanadu)", "Andrew Lippman com equipa do MIT (financiado pela ARPA)", "Tim Berners-Lee (no CERN)", "Douglas Engelbart (no Stanford Research Institute)"],
        answer: "Andrew Lippman com equipa do MIT (financiado pela ARPA)"
    },
    // Tema 15: Sociedade de Informação e Ética
    {
        question: "O que é a esteganografia?",
        options: ["A técnica de decifrar códigos militares alemães.", "A disciplina de encriptar ficheiros usando senhas complexas.", "A arte de escrever textos filosóficos complexos.", "A técnica de esconder a existência de uma mensagem dentro de outra (ex: alterando pixéis numa imagem)."],
        answer: "A técnica de esconder a existência de uma mensagem dentro de outra (ex: alterando pixéis numa imagem)."
    },
    {
        question: "Quem é considerado o pai da ética?",
        options: ["Platão", "Aristóteles", "Sócrates", "Copérnico"],
        answer: "Sócrates"
    },
    {
        question: "Qual é o outro nome para a \"ética de salvaguarda\" do escritor Michel Lacroix?",
        options: ["Princípio da Precaução", "Ética do Utilitarismo", "Lei de Asimov", "Moralidade Tecnológica"],
        answer: "Princípio da Precaução"
    },
    {
        question: "Como se define a Cibernética?",
        options: ["O estudo exclusivo de robôs industriais e as suas peças mecânicas.", "A ciência interdisciplinar que estuda sistemas complexos de comunicação, controlo e feedback, equiparando organismos vivos a máquinas.", "A ramificação da informática dedicada à criação de vírus de computador.", "O uso de implantes eletrónicos no corpo humano."],
        answer: "A ciência interdisciplinar que estuda sistemas complexos de comunicação, controlo e feedback, equiparando organismos vivos a máquinas."
    },
    {
        question: "Pelo que é caracterizada a 3ª Revolução Industrial?",
        options: ["Pela invenção da máquina a vapor e mecanização têxtil.", "Pela introdução da eletricidade e linhas de montagem.", "Pela inteligência artificial autónoma e robótica de consumo.", "Pela Revolução Digital/Informática (computadores, internet, telecomunicações)."],
        answer: "Pela Revolução Digital/Informática (computadores, internet, telecomunicações)."
    },
    {
        question: "Quando foi o lançamento do satélite Sputnik que inaugurou a era espacial?",
        options: ["4 de outubro de 1957", "20 de julho de 1969", "12 de abril de 1961", "1 de janeiro de 1950"],
        answer: "4 de outubro de 1957"
    },
    // Tema 17: Inteligência Artificial (IA) e Robótica
    {
        question: "Onde foi fundada formalmente a disciplina \"Inteligência Artificial\" e onde se debateu a \"IA benéfica\" em 2017?",
        options: ["Universidade de Stanford (1956) e Conferência do MIT (2017).", "Bletchley Park (1950) e Universidade de Oxford (2017).", "Dartmouth College (1956) e Conferência de Asilomar (2017).", "RAND Corporation (1960) e Fórum Económico Mundial (2017)."],
        answer: "Dartmouth College (1956) e Conferência de Asilomar (2017)."
    },
    {
        question: "Quem batizou a disciplina cunhando a expressão \"Inteligência Artificial\" em 1955?",
        options: ["Alan Turing", "John McCarthy", "Marvin Minsky", "Isaac Asimov"],
        answer: "John McCarthy"
    },
    {
        question: "O que procura a Inteligência Artificial?",
        options: ["Substituir a lógica humana por máquinas puramente a vapor.", "Criar algoritmos e sistemas dotados da capacidade de emular as funções cognitivas humanas (raciocinar, aprender, decidir).", "Eliminar a necessidade de hardware físico no processamento de dados.", "Construir bases de dados não-lineares hiperligadas à escala global."],
        answer: "Criar algoritmos e sistemas dotados da capacidade de emular as funções cognitivas humanas (raciocinar, aprender, decidir)."
    },
    {
        question: "Quais são as 4 grandes áreas tradicionais da IA?",
        options: ["Sistemas Periciais, Processamento de Linguagem Natural, Visão Computacional e Robótica.", "Máquinas de Turing, Redes Neuronais, Compiladores e Sistemas Operativos.", "Hardware, Software, Periféricos e Memória.", "Lógica Booleana, Álgebra Computacional, Criptografia e Cibernética."],
        answer: "Sistemas Periciais, Processamento de Linguagem Natural, Visão Computacional e Robótica."
    },
    {
        question: "Quais são as duas vias principais de pesquisa em Inteligência Artificial?",
        options: ["Analógica e Digital", "Mecânica e Eletrónica", "Teórica e Experimental", "IA Simbólica (Top-Down/Clássica) e IA Conexionista (Bottom-Up/Redes Neuronais)."],
        answer: "IA Simbólica (Top-Down/Clássica) e IA Conexionista (Bottom-Up/Redes Neuronais)."
    },
    {
        question: "O que são redes neuronais artificiais?",
        options: ["Redes de fibra ótica desenhadas para interligar computadores a nível global.", "Modelos computacionais inspirados na estrutura nervosa do cérebro biológico, capazes de aprender padrões sem programação explícita.", "A malha de fios elétricos que conecta os microprocessadores na arquitetura de Von Neumann.", "Algoritmos que apenas executam rotinas lógicas clássicas baseadas em \"Se-Então\"."],
        answer: "Modelos computacionais inspirados na estrutura nervosa do cérebro biológico, capazes de aprender padrões sem programação explícita."
    },
    {
        question: "Em que consiste o Teste de Turing?",
        options: ["Num teste físico para provar que a Terra se move em redor do Sol.", "Num protocolo para verificar falhas nos tubos de vácuo do computador Colossus.", "Num método empírico em que um avaliador tenta distinguir se as respostas de texto provêm de um humano ou de uma máquina.", "Num sistema que mede o tempo que uma máquina leva a compilar um código escrito em A-0."],
        answer: "Num método empírico em que um avaliador tenta distinguir se as respostas de texto provêm de um humano ou de uma máquina."
    },
    {
        question: "Como se define um robô?",
        options: ["Um programa de software que pesquisa hipertextos na World Wide Web.", "Um mecanismo artificial e autónomo que manipula fisicamente a realidade para cumprir tarefas.", "Qualquer máquina de cálculo, independentemente de ter interação com o mundo físico ou não.", "Um computador analógico da 1ª geração."],
        answer: "Um mecanismo artificial e autónomo que manipula fisicamente a realidade para cumprir tarefas."
    },
    {
        question: "Quem enunciou as \"3 leis da robótica\" em 1950?",
        options: ["George Devol", "Alan Turing", "Arthur C. Clarke", "Isaac Asimov"],
        answer: "Isaac Asimov"
    },
    {
        question: "Qual foi o primeiro robô industrial e quem o construiu?",
        options: ["R2-D2; George Lucas.", "Shakey; Instituto de Pesquisa de Stanford.", "Unimate; George Devol e Joseph Engelberger (1961).", "Colossus; Tommy Flowers e Alan Turing."],
        answer: "Unimate; George Devol e Joseph Engelberger (1961)."
    },
    // Outros Temas (Civilizações Antigas, Roma, Idade Média e Revolução Industrial)
    {
        question: "Quem decifrou os hieróglifos do Egito Antigo e que artefato foi fulcral para isso?",
        options: ["Henry Rawlinson com a Pedra de Rosetta.", "Jean-François Champollion com a Pedra de Roseta.", "Howard Carter com os túmulos do Vale dos Reis.", "Arthur Evans com os Papiros de Alexandria."],
        answer: "Jean-François Champollion com a Pedra de Roseta."
    },
    {
        question: "Qual o tipo de escrita desenvolvida pela civilização Suméria e o seu suporte?",
        options: ["Demótico em papiro.", "Cuneiforme em placas de argila mole.", "Oracular em ossos.", "Hieróglifos em paredes de pedra."],
        answer: "Cuneiforme em placas de argila mole."
    },
    {
        question: "Quem decifrou a escrita cuneiforme e em que se baseou?",
        options: ["Jean-François Champollion baseando-se em textos em grego e demótico.", "Henry Rawlinson baseando-se numa inscrição em três línguas (Persa, Acádico e Elamita).", "Heinrich Schliemann baseando-se em textos celtas.", "Michael Ventris baseando-se no Linear B."],
        answer: "Henry Rawlinson baseando-se numa inscrição em três línguas (Persa, Acádico e Elamita)."
    },
    {
        question: "Em que língua/escrita comunicava a antiga civilização do Rio Amarelo (China)?",
        options: ["Chinês Antigo, através de escrita oracular em ossos e carapaças de tartaruga (Jiaguwen).", "Mandarim Moderno escrito em pergaminhos de seda.", "Escrita cuneiforme em placas de terracota.", "Hieróglifos pictográficos pintados em bambu."],
        answer: "Chinês Antigo, através de escrita oracular em ossos e carapaças de tartaruga (Jiaguwen)."
    },
    {
        question: "Que civilização europeia foi diretamente influenciada pelos saberes das civilizações hidráulicas (Egipto e Mesopotâmia)?",
        options: ["Civilização Celta", "Império Romano", "Civilização Grega", "Civilização Viking"],
        answer: "Civilização Grega"
    },
    {
        question: "Quais foram três legados cruciais do Império Romano?",
        options: ["A filosofia estóica, a pólvora e a bússola.", "O Direito (leis), o Urbanismo e as Línguas Latinas.", "A democracia ateniense, a matemática abstrata e a navegação astronómica.", "O papel, a xilografia e a arquitetura gótica."],
        answer: "O Direito (leis), o Urbanismo e as Línguas Latinas."
    },
    {
        question: "Quais os principais tipos de construções públicas inovadoras deixadas pelo Império Romano?",
        options: ["Zigurates e mastabas.", "Pirâmides e obeliscos.", "Aquedutos e anfiteatros.", "Catedrais e claustros."],
        answer: "Aquedutos e anfiteatros."
    },
    {
        question: "Como se dividia a rede viária construída pelos romanos?",
        options: ["Estradas de alcatrão, trilhos de madeira e túneis.", "Estradas fluviais, canais e pontes suspensas.", "Estradas de terra batida, estradas de saibro e estradas calçadas (em pedra).", "Vias-férreas, vias pedonais e percursos de caravanas."],
        answer: "Estradas de terra batida, estradas de saibro e estradas calçadas (em pedra)."
    },
    {
        question: "Onde foi inventado o moinho de água e qual a sua principal função original?",
        options: ["No Egipto; servia para elevar a água do rio Nilo.", "Em Roma; servia para fornecer água aos balneários.", "Na Grécia Antiga; servia para transformar energia cinética em mecânica para moer grãos de cereais.", "Na Mesopotâmia; servia para ativar sistemas de rega gota-a-gota."],
        answer: "Na Grécia Antiga; servia para transformar energia cinética em mecânica para moer grãos de cereais."
    },
    {
        question: "Que ordens monásticas se destacaram no desenvolvimento agrário e inovação na Idade Média?",
        options: ["Templários e Hospitalários.", "Dominicanos e Franciscanos.", "Jesuítas e Carmelitas.", "Beneditinos e Cistercienses (Ordem de Cister)."],
        answer: "Beneditinos e Cistercienses (Ordem de Cister)."
    },
    {
        question: "A quem é historicamente atribuída a invenção do parafuso sem fim (ou parafuso de elevação de água)?",
        options: ["Heron de Alexandria", "Aristóteles", "Arquimedes de Siracusa", "Galileu Galilei"],
        answer: "Arquimedes de Siracusa"
    },
    {
        question: "Quais eram três instrumentos antigos essenciais de apoio à navegação?",
        options: ["Bússola, astrolábio e quadrante.", "Telescópio, sextante e radar.", "Relógio de sol, barómetro e higrómetro.", "Eolípila, ábaco e astrolábio."],
        answer: "Bússola, astrolábio e quadrante."
    },
    {
        question: "O que levou ao grande desenvolvimento das marinhas das repúblicas do norte de Itália (como Veneza e Génova) na Idade Média?",
        options: ["A necessidade de combater piratas nórdicos no Atlântico.", "O desejo de colonizar as Américas.", "A necessidade de dominar as rotas comerciais do Mediterrâneo e monopolizar especiarias/sedas do Oriente.", "O transporte massivo de peregrinos romanos para Santiago de Compostela."],
        answer: "A necessidade de dominar as rotas comerciais do Mediterrâneo e monopolizar especiarias/sedas do Oriente."
    },
    {
        question: "Que alterações estruturais sofreram os castelos devido à vulgarização da artilharia a pólvora?",
        options: ["As muralhas tornaram-se mais altas e finas para dificultar a mira dos canhões.", "As muralhas passaram a ser mais baixas e espessas (maciças), surgindo os baluartes em formato angular.", "Os castelos passaram a ser construídos exclusivamente no subsolo.", "Substituíram-se as pedras por estruturas de madeira para absorver melhor o impacto."],
        answer: "As muralhas passaram a ser mais baixas e espessas (maciças), surgindo os baluartes em formato angular."
    },
    {
        question: "Quais foram as três descobertas/invenções principais que impulsionaram o Renascimento?",
        options: ["Máquina a vapor, eletricidade e telégrafo.", "Pólvora, imprensa e bússola.", "Transístores, válvulas e cuneiforme.", "Astrolábio, roda dentada e geometria."],
        answer: "Pólvora, imprensa e bússola."
    },
    {
        question: "Quem inventou a imprensa moderna em 1450 e em que base assentava na sua evolução genial?",
        options: ["Blaise Pascal; cilindros rotativos.", "Johannes Kepler; placas litográficas.", "Johannes Gutenberg; sistema de caracteres móveis.", "Leonardo da Vinci; carimbos de cera."],
        answer: "Johannes Gutenberg; sistema de caracteres móveis."
    },
    {
        question: "O que defendiam Galileu Galilei e Johannes Kepler sobre o Universo?",
        options: ["Galileu defendeu o geocentrismo perfeito; Kepler provou que a Terra era plana.", "Galileu provou o heliocentrismo (Sol no centro imóvel); Kepler postulou que as órbitas dos planetas são trajetórias elípticas.", "Ambos defendiam que o Sol girava em torno da Terra, mas em órbitas elípticas.", "Galileu descobriu as leis da gravidade; Kepler inventou o telescópio refrator."],
        answer: "Galileu provou o heliocentrismo (Sol no centro imóvel); Kepler postulou que as órbitas dos planetas são trajetórias elípticas."
    },
    {
        question: "A que pena foi condenado Galileu pelo tribunal do Santo Ofício e porquê?",
        options: ["Exílio na Grécia; por inventar o telescópio.", "Execução pública; por roubar manuscritos da Igreja.", "Prisão domiciliária perpétua; por defender a heresia científica do heliocentrismo.", "Confisco de bens; por apoiar a Reforma Protestante."],
        answer: "Prisão domiciliária perpétua; por defender a heresia científica do heliocentrismo."
    },
    {
        question: "A quem se deve a fundação do método experimental e científico moderno?",
        options: ["Isaac Newton e Aristóteles", "Copérnico e Ptolomeu", "Charles Babbage e Ada Lovelace", "Galileu Galilei e Francis Bacon"],
        answer: "Galileu Galilei e Francis Bacon"
    },
    {
        question: "Qual foi a primeira manifestação prática da utilização do vapor na história?",
        options: ["O tear a vapor de Jacquard.", "O motor marítimo de Fulton.", "A \"Eolípila\" (máquina de abrir portas de templo) projetada por Heron de Alexandria.", "A bomba de extração de água das minas de Newcomen."],
        answer: "A \"Eolípila\" (máquina de abrir portas de templo) projetada por Heron de Alexandria."
    },
    {
        question: "Quais foram as 4 inovações vitais que James Watt adicionou à máquina a vapor de Newcomen?",
        options: ["Caldeira a carvão, tubo de escape, volante de inércia e pistão de madeira.", "Condensador, êmbolo de duplo efeito, engrenagem epicicloidal (movimento rotativo) e o regulador centrífugo (piloto).", "Válvula de segurança, manómetro, injetor elétrico e ignição por faísca.", "Correia de transmissão, rodas de ferro, radiador e cilindros duplos."],
        answer: "Condensador, êmbolo de duplo efeito, engrenagem epicicloidal (movimento rotativo) e o regulador centrífugo (piloto)."
    }
];

// Estado interno do quiz
const quizState = {
    shuffledQuestions: [],
    currentIndex: 0,
    correctCount: 0,
    answered: false
};

// Referências DOM
const elements = {
    quizContainer: document.getElementById("quiz-container"),
    progressFill: document.getElementById("progress-fill"),
    progressText: document.getElementById("progress-text"),
    scoreLive: document.getElementById("score-live"),
    btnNext: document.getElementById("btn-next"),
    btnRestart: document.getElementById("btn-restart"),
    results: document.getElementById("results"),
    scoreMessage: document.getElementById("score-message"),
    emojiResult: document.getElementById("emoji-result"),
    summary: document.getElementById("summary")
};

/**
 * Algoritmo Fisher-Yates Shuffle
 */
function fisherYatesShuffle(array) {
    const arr = [...array];
    for (let i = arr.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [arr[i], arr[j]] = [arr[j], arr[i]];
    }
    return arr;
}

/**
 * Prepara as perguntas: baralha ordem e opções.
 */
function prepareQuestions(questions) {
    return fisherYatesShuffle(questions).map((q) => ({
        question: q.question,
        answer: q.answer,
        options: fisherYatesShuffle(q.options)
    }));
}

function escapeHtml(text) {
    const div = document.createElement("div");
    div.textContent = text;
    return div.innerHTML;
}

/**
 * Atualiza barra de progresso e contador de acertos.
 */
function updateProgress() {
    const total = quizState.shuffledQuestions.length;
    const current = Math.min(quizState.currentIndex + 1, total);
    const percentage = total > 0 ? (quizState.currentIndex / total) * 100 : 0;

    elements.progressFill.style.width = `${percentage}%`;
    elements.progressText.textContent = `Pergunta ${current} de ${total}`;
    elements.scoreLive.textContent = `Acertos: ${quizState.correctCount}`;
}

/**
 * Renderiza a pergunta atual.
 */
function renderCurrentQuestion() {
    const q = quizState.shuffledQuestions[quizState.currentIndex];
    if (!q) return;

    quizState.answered = false;
    elements.btnNext.classList.add("hidden");
    elements.results.classList.add("hidden");

    const card = document.createElement("article");
    card.className = "question-card";
    card.innerHTML = `
        <p class="question-number">Pergunta ${quizState.currentIndex + 1}</p>
        <h2 class="question-text">${escapeHtml(q.question)}</h2>
        <ul class="options-list" role="radiogroup">
            ${q.options.map((option, optIndex) => `
                <li class="option-item">
                    <input type="radio" name="current-question" id="opt-${optIndex}" value="${escapeHtml(option)}">
                    <label for="opt-${optIndex}">${escapeHtml(option)}</label>
                </li>
            `).join("")}
        </ul>
        <div class="feedback hidden" data-feedback></div>
    `;

    card.querySelectorAll('input[type="radio"]').forEach((radio) => {
        radio.addEventListener("change", () => onAnswerSelected(card, q));
    });

    elements.quizContainer.innerHTML = "";
    elements.quizContainer.appendChild(card);
    updateProgress();
}

/**
 * Quando o utilizador escolhe uma resposta: verifica, mostra feedback e prepara avanço.
 */
function onAnswerSelected(card, question) {
    if (quizState.answered) return;

    const selected = card.querySelector('input[name="current-question"]:checked');
    if (!selected) return;

    quizState.answered = true;
    const selectedValue = selected.value;
    const isCorrect = selectedValue === question.answer;

    if (isCorrect) {
        quizState.correctCount++;
        card.classList.add("correct");
    } else {
        card.classList.add("incorrect");
    }

    highlightOptions(card, selectedValue, question.answer);
    showFeedback(card, selectedValue, question.answer, isCorrect);
    updateProgress();

    elements.btnNext.classList.remove("hidden");
    elements.btnNext.textContent =
        quizState.currentIndex < quizState.shuffledQuestions.length - 1
            ? "Seguinte"
            : "Ver Resultados";
}

/**
 * Mostra feedback imediato após responder.
 */
function showFeedback(card, selected, correctAnswer, isCorrect) {
    const feedback = card.querySelector("[data-feedback]");
    feedback.classList.remove("hidden");
    feedback.classList.add(isCorrect ? "feedback-success" : "feedback-error");

    if (isCorrect) {
        feedback.innerHTML = `
            <p class="feedback-title">✅ Correto!</p>
            <p class="feedback-line feedback-correct">${escapeHtml(correctAnswer)}</p>
        `;
    } else {
        feedback.innerHTML = `
            <p class="feedback-title">❌ Errado</p>
            <p class="feedback-line feedback-wrong">Respondeste: <strong>${escapeHtml(selected)}</strong></p>
            <p class="feedback-line feedback-correct">Resposta correta: <strong>${escapeHtml(correctAnswer)}</strong></p>
        `;
    }
}

/**
 * Destaca opções corretas (verde) e erradas (vermelho).
 */
function highlightOptions(card, selected, correctAnswer) {
    card.querySelectorAll(".option-item").forEach((item) => {
        const value = item.querySelector("input").value;
        item.classList.add("disabled");

        if (value === correctAnswer) {
            item.classList.add("correct-option");
        } else if (value === selected) {
            item.classList.add("wrong-option");
        }
    });
}

/**
 * Avança para a próxima pergunta ou mostra resultados finais.
 */
function advanceQuestion() {
    if (!quizState.answered) return;

    quizState.currentIndex++;

    if (quizState.currentIndex >= quizState.shuffledQuestions.length) {
        showFinalResults();
        return;
    }

    renderCurrentQuestion();
}

/**
 * Mostra o resumo final com pontuação e percentagem.
 */
function showFinalResults() {
    const total = quizState.shuffledQuestions.length;
    const correct = quizState.correctCount;
    const wrong = total - correct;
    const percentage = Math.round((correct / total) * 100);

    elements.quizContainer.innerHTML = "";
    elements.btnNext.classList.add("hidden");
    elements.results.classList.remove("hidden");
    elements.progressFill.style.width = "100%";
    elements.progressText.textContent = `Concluído — ${total} perguntas`;

    elements.scoreMessage.textContent = `Acertaste ${correct} de ${total} perguntas.`;

    if (percentage > 80) {
        elements.emojiResult.textContent = "🎉";
    } else if (percentage < 50) {
        elements.emojiResult.textContent = "😢";
    } else {
        elements.emojiResult.textContent = "👍";
    }

    elements.summary.innerHTML = `
        <div class="summary-item">
            <span class="value">${correct}/${total}</span>
            <span class="label">Pontuação</span>
        </div>
        <div class="summary-item">
            <span class="value">${percentage}%</span>
            <span class="label">Percentagem</span>
        </div>
        <div class="summary-item">
            <span class="value">${correct}</span>
            <span class="label">Certas</span>
        </div>
        <div class="summary-item">
            <span class="value">${wrong}</span>
            <span class="label">Erradas</span>
        </div>
    `;

    elements.results.scrollIntoView({ behavior: "smooth", block: "start" });
}

/**
 * Reinicia o quiz completamente.
 */
function restartQuiz() {
    quizState.currentIndex = 0;
    quizState.correctCount = 0;
    quizState.answered = false;
    quizState.shuffledQuestions = prepareQuestions(QUESTIONS);

    elements.results.classList.add("hidden");
    elements.scoreMessage.textContent = "";
    elements.emojiResult.textContent = "";
    elements.summary.innerHTML = "";
    elements.btnNext.classList.add("hidden");

    renderCurrentQuestion();
}

function init() {
    quizState.shuffledQuestions = prepareQuestions(QUESTIONS);
    renderCurrentQuestion();

    elements.btnNext.addEventListener("click", advanceQuestion);
    elements.btnRestart.addEventListener("click", restartQuiz);
}

init();
