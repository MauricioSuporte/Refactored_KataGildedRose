<template>
    <div>
        <h2>Dia {{dias}}</h2>
        <table class="table table-bordered table-striped table-dark text-center">
            <thead>
                <tr>
                    <th>
                        Nome
                    </th>
                    <th>
                        Prazo Para Venda
                    </th>
                    <th>
                        Qualidade
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="item in itens" v-bind:key="item.nome" >
                    <td>
                        {{item.nome}}
                    </td>
                    <td>
                        {{item.prazoParaVenda}}
                    </td>
                    <td>
                        {{item.qualidade}}
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="text-center">
            <button v-on:click="atualizarQualidade()" type="button" class="btn btn-primary">Atualizar Qualidade</button>
        </div>
    </div>
</template>

<script>
import axios from 'axios';
let scopoItens = null;
export default {
  name: 'Itens',
  data: () => {
    if (sessionStorage.length == 0) {
      sessionStorage.setItem("dias", 1);
    }

    return {
      itens: [],
      dias: sessionStorage.getItem("dias"),
    }
  },
  methods: {
    listar: () => {
          axios.get(`https://localhost:44323/api`).then((res)=> {
        scopoItens.itens = res.data
      })
    },
    atualizarQualidade: () => {
        scopoItens.adicionarDias()
        axios.post(`https://localhost:44323/api/att`).then((res)=> {
            scopoItens.itens = res.data
        })
    },
    adicionarDias: () => {
        var counter = sessionStorage.getItem("dias");
        counter++;
        sessionStorage.setItem("dias", counter);
        scopoItens.dias = counter;
    }
  },
  created() {
    scopoItens = this;
    this.listar()
  }
}

window.addEventListener("beforeunload", function () {
  localStorage.removeItem('dias');
});
</script>

<style scoped>
button {
  margin-bottom: 3%;
}

h2 {
  color: #4beb7b;
  font-size: 35px;
  text-align: center;
  font-family: Brush Script MT;
}
</style>