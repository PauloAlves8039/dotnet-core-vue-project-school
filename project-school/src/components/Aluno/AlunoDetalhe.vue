<template>
  <div>
    <titulo :texto="`Aluno: ${aluno.nome}`" :btnVoltar="false">
      <button class="btn btnEditar">Editar</button>
    </titulo>

    <table>
      <tbody>
        <tr>
          <td class="colPequeno">Matrícula:</td>
          <td>
            <label>{{ aluno.id }}</label>
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Nome:</td>
          <td>
            <label>{{ aluno.nome }}</label>
            <input v-model="aluno.nome" type="text" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Sobrenome:</td>
          <td>
            <label>{{ aluno.sobrenome }}</label>
            <input v-model="aluno.sobrenome" type="text" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Data Nascimento</td>
          <td>
            <label>{{ aluno.dataNasc }}</label>
            <input v-model="aluno.dataNasc" type="text" />
          </td>
        </tr>
        <tr>
          <td class="colPequeno">Professor:</td>
          <td>
            <label>{{ aluno.professor.nome }}</label>
            <select v-model="aluno.professor">
              <option
                v-for="(professor, index) in professores"
                :key="index"
                v-bind:value="professor"
              >
                {{ professor.nome }}
              </option>
            </select>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import Titulo from "../_share/Titulo.vue";

export default {
  components: {
    Titulo,
  },
  data() {
    return {
      id: this.$route.params.id,
      aluno: {},
      professores: [],
      urlAluno: "http://localhost:3000/alunos",
      urlProfessor: "http://localhost:3000/professores",
    };
  },
  created() {
    this.$http
      .get(`${this.urlAluno}/${this.id}`)
      .then((res) => res.json())
      .then((aluno) => (this.aluno = aluno));

    this.$http
      .get(this.urlProfessor)
      .then((res) => res.json())
      .then((professor) => (this.professores = professor));
  },
  methods: {},
};
</script>

<style scoped>
.btnEditar {
  float: right;
  background-color: rgb(76, 186, 249);
}
.colPequeno {
  width: 20%;
  text-align: right;
  background-color: rgb(125, 217, 245);
  font-weight: bold;
}
input,
select {
  margin: 0px;
  padding: 5px 10px;
  font-size: 0.9em;
  font-family: Montserrat;
  border-radius: 5px;
  border: 1px solid silver;
  background-color: rgb(245, 245, 245);
  width: 95%;
}
</style>