<template>
  <div>
    <h1>{{ titulo }}</h1>
    <input
      type="text"
      placeholder="Nome do Aluno"
      v-model="nome"
      v-on:keyup.enter="addAluno()"
    />
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
            <button class="btn" @click="remover(aluno)">Remover</button>
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
</style>
