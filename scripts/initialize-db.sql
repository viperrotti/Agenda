CREATE TABLE IF NOT EXISTS Professor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    url VARCHAR(255),
    materia VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS Agenda (
    id INT AUTO_INCREMENT PRIMARY KEY,
    hora VARCHAR(255) NOT NULL,    
    data VARCHAR(255) NOT NULL,
    professorId INT,
    FOREIGN KEY (ProfessorId) REFERENCES Professor(id)
);

INSERT INTO Professor (nome, url, materia) VALUES
  ('Renata', 'img/Renata.jpg', 'Historia'),
  ('Carla', 'img/Carla.jpg', 'Matematica'),
  ('Paulo', 'img/Paulo.jpg', 'Fisica'),
  ('Emanuel', 'img/Emanuel.jpg', 'Geografia'),
  ('Barbara', 'img/Barbara.jpg', 'Quimica'),
  ('Sergio', 'img/Sergio.jpg', 'Artes'),
  ('Jessica', 'img/Jessica.jpg', 'Biologia'),
  ('Marcio', 'img/Marcio.jpg', 'Ingles')
