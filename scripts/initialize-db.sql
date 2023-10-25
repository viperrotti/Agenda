CREATE TABLE IF NOT EXISTS Professor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    url VARCHAR(255),
    materia VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS Agenda (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,    
    data DATETIME NOT NULL,
    professorId INT,
    FOREIGN KEY (ProfessorId) REFERENCES Professor(id)
);

INSERT INTO Professor (nome, url, materia) VALUES
  ('Viviane', 'http://url1.com', 'Quimica'),
  ('Renato', 'http://url2.com', 'Matematica')
