<template>
  <div id="app" class="text-center container">
    <Titulo titulo="🌹🏵Gilded Rose🏵🌹"/>
    <img alt="Gilded logo" src="./assets/logo.png">
    <hr>
    <Itens/>
    <Footer/>
  </div>
</template>

<script>
import Itens from './components/Itens'
import Titulo from './components/Titulo'
import Footer from './components/Footer'

export default {
  name: 'App',
  components: {
    Itens,
    Titulo,
    Footer
  }
}
</script>