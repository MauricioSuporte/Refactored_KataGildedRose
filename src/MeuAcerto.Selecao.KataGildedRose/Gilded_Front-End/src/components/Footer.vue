<template>
    <div id="footer">
        <span>💻 Made by Maurício Suporte</span>
    </div>
</template>

<script>
export default {
  name: 'Footer',
  props: {
      footer: String
  }
}
</script>

<style scoped>
span {
  color: #fff;
  font-size: 20px;
  text-align: center;
  background-color: #333;
  position: fixed;
  left: 0;
  bottom: 0;
  width: 100%;
}
</style>