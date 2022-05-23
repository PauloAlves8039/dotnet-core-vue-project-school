<template>
  <div>
    <h1>{{ titulo }}</h1>
    <div>
      <input
        type="text"
        placeholder="Nome do Aluno"
        v-model="nome"
        @keyup.enter="addAluno()"
      />
      <button class="btn btnInput" @click="addAluno()">Adicionar</button>
    </div>
    <table border="1px">
      <thead>
        <th>Mat.</th>
        <th>Nome</th>
        <th>Opções</th>
      </thead>
      <tbody>
        <tr v-for="(aluno, index) in alunos" :key="index">
          <td>{{ index + 1 }}</td>
          <!-- <td>{{ aluno.id }}</td> -->
          <td>{{ aluno.nome }}</td>
          <td>
            <button class="btn btn_Danger" @click="remover(aluno)">
              Remover
            </button>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
export default {
  data() {
    return {
      titulo: "Aluno",
      nome: "",
      alunos: [
        { id: 1, nome: "Paulo" },
        { id: 2, nome: "Isadora" },
        { id: 3, nome: "Maria" },
      ],
    };
  },
  props: {},
  methods: {
    addAluno() {
      let _aluno = {
        nome: this.nome,
      };
      this.alunos.push(_aluno);
      this.nome = "";
    },
    remover(aluno) {
      let indice = this.alunos.indexOf(aluno);
      this.alunos.splice(indice, 1);
    },
  },
};
</script>

<style scoped>
input {
  border: 0;
  padding: 20px;
  font-size: 1.3em;
  color: #687f7f;
  display: inline;
}
.btnInput {
  border: 0px;
  padding: 20px;
  font-size: 1.3em;
  display: inline;
  background-color: rgb(116, 115, 115);
}
.btnInput:hover {
  padding: 20px;
  margin: 0px;
  border: 0px;
}
</style>
