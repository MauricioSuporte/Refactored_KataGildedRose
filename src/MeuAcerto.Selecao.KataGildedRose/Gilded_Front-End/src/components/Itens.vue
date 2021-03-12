<template>
    <div>
        <table>
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
                <tr v-for="item in itens" v-bind:key="item.nome">
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
    </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'Itens',
  data: () => {
    return {
      itens: [],
    }
  },
  methods: {
    lista: (scope) => {
      axios.get(`https://localhost:44336/api`).then((res)=> {
        console.log(res)
        scope.itens = res.data
      })
    }
  },
  created() {
    this.lista(this)
  }
}
</script>