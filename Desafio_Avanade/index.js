const express = require('express');
const bodyParser = require('body-parser');
const app = express();

app.use(bodyParser.json());

var listaProfessor = [];
var listaCurso = [];

function getProfessor(req, res) {
    res.send(listaProfessor);
}

    app.get('/professor', getProfessor);

function getCurso(req, res) {
    res.send(listaCurso);
}

    app.get('/curso', getCurso);


function getProfessorById(req, res) {
    const professorId = req.params.idProfessor;
    const professorPesquisado = listaProfessor.find((professorNaLista) => professorNaLista.idProfessor == professorId);
    if(!professorPesquisado){
        res.send(`Não existe um professor com o idProfessor ${professorId}`)
    } else {
        res.send(professorPesquisado);
    }
}

    app.get('/professor/:idProfessor', getProfessorById);


function getCursoById(req, res) {
    const cursoId = req.params.idCurso;
    const cursoPesquisado = listaCurso.find((cursoNaLista) => cursoNaLista.idCurso == cursoId);
    if(!cursoPesquisado){
        res.send(`Não existe um curso com o idCurso ${cursoId}`)
    } else {
        res.send(cursoPesquisado);
    }
}

    app.get('/curso/:idCurso', getCursoById);

function criandoProfessor(req, res) {
    const professor = req.body;
    const professorPesquisado = listaProfessor.find((professorNaLista) => professorNaLista.idProfessor === professor.idProfessor);
    if (!professorPesquisado) {
        listaProfessor.push(professor);
        res.send('Inserido com sucesso');
    } else {
        res.send(`Não é possível inserir, pois já existe um professor com o idProfessor ${professor.idProfessor}`);
    }
}

    app.post('/professor', criandoProfessor);

function criandoCurso(req, res) {
    const curso = req.body;
    const cursoPesquisado = listaCurso.find((cursoNaLista) => cursoNaLista.idCurso === curso.idCurso);
    if (!cursoPesquisado) {
        listaCurso.push(curso);
        res.send('Inserido com sucesso');
    } else {
        res.send(`Não é possível inserir, pois já existe um curso com o idCurso ${curso.idCurso}`);
    }
}

    app.post('/curso', criandoCurso);

function updateProfessor(req, res) {
    const professorId = req.params.idProfessor;
    const professor = req.body;
    const professorPesquisado = listaProfessor.find((professorNaLista) => professorNaLista.idProfessor == professorId);
    if(!professorPesquisado){
        res.send(`Não existe um professor com o idProfessor ${professorId}`)
    } else {
        professorPesquisado.idProfessor = professor.idProfessor;
        professorPesquisado.name = professor.name;
    
        res.send(`Professor de idProfessor ${professorId} alterado com sucesso!`);
    }
}

    app.put('/professor/:idProfessor', updateProfessor);

function updateCurso(req, res) {
    const cursoId = req.params.idCurso;
    const curso = req.body;
    const cursoPesquisado = listaCurso.find((cursoNaLista) => cursoNaLista.idCurso == cursoId);
    if(!cursoPesquisado){
        res.send(`Não existe um curso com o idCurso ${cursoId}`)
    } else {
        cursoPesquisado.idCurso = curso.idCurso;
        cursoPesquisado.name = curso.name;
    
        res.send(`Curso de idCurso ${cursoId} alterado com sucesso!`);
    }
}

    app.put('/curso/:idCurso', updateCurso);

function deleteProfessor(req, res) {
    const professorId = req.params.idProfessor;
    listaProfessor = listaProfessor.filter((professor) => professor.idProfessor != professorId);
    if(!professorPesquisado){
        res.send(`Não existe um professor com o idProfessor ${professorId}`)
    } else {
        res.send(`Professor de idProfessor ${professorId} foi deletado com sucesso!`);
    }
}

    app.delete('/professor/:idProfessor', deleteProfessor);

function deleteCurso(req, res) {
    const cursoId = req.params.idCurso;
    listaCurso = listaCurso.filter((curso) => curso.idCurso != cursoId);
    if(!cursoPesquisado){
        res.send(`Não existe um curso com o idCurso ${cursoId}`)
    } else {
        res.send(`Curso de idCurso ${cursoId} foi deletado com sucesso!`);
    }
}

    app.delete('/curso/:idCurso', deleteCurso);

app.get("/", (req, res) => {
    
});

app.listen(8080, () =>{
    console.log("Servidor iniciado na porta 8080: http://localhost:8080/");

});

    




