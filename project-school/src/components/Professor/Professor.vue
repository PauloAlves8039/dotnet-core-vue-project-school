<template>
  <div>
    <titulo texto="Professor" />
    <table>
      <thead>
        <th>Cód.</th>
        <th>Nome</th>
        <th>Alunos</th>
      </thead>
      <tbody v-if="Professores.length">
        <tr v-for="(professor, index) in Professores" :key="index">
          <td>{{ professor.id }}</td>
          <td>{{ professor.nome }} {{ professor.sobrenome }}</td>
          <td>3</td>
        </tr>
      </tbody>
      <tfoot v-else>
        Nenhum Professor Encontrado
      </tfoot>
    </table>
  </div>
</template>

<script>
import Titulo from "../_share/Titulo";

export default {
  components: {
    Titulo,
  },
  data() {
    return {
      Professores: [
        { id: 1, nome: "Gabriela" },
        { id: 2, nome: "Pedro" },
        { id: 3, nome: "Silvana" },
      ],
    };
  },
};
</script>

<style scoped>
</style>