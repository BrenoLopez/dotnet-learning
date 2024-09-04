## Convensões de escrita 
- Os nomes das interfaces começam com maiúsculo I.

- Os tipos de atributos terminam com a palavra Attribute.

- Os tipos Enum usam um substantivo singular para não sinalizadores e um substantivo plural para sinalizadores.

- Os identificadores não devem conter dois _caracteres sublinhados (\_) consecutivos. Esses nomes são reservados para identificadores gerados pelo compilador.

- Use nomes significativos e descritivos para variáveis, métodos e classes.

- Prefira clareza à brevidade.

- Use PascalCase para nomes de classes e métodos.

- Use camelCase para parâmetros de método e variáveis locais.

- Use PascalCase para nomes de constantes, tanto de campos quanto de constantes locais.

- Os campos de instância privada começam com um sublinhado (_) e o texto restante é camelCased.

- Campos estáticos começam com s_. Esta convenção não é o comportamento padrão do Visual Studio, nem faz parte das diretrizes de design do Framework , mas é configurável em editorconfig .

- Evite usar abreviações ou siglas em nomes, exceto abreviações amplamente conhecidas e aceitas.

- Use namespaces significativos e descritivos que sigam a notação reversa de nome de domínio.

- Escolha nomes de montagem que representem o propósito principal da montagem.

- Evite usar nomes de uma única letra, exceto para contadores de loop simples. Além disso, exemplos de sintaxe que descrevem a sintaxe de construções C# geralmente usam os seguintes nomes de uma única letra que correspondem à convenção usada na especificação da linguagem C# . Exemplos de sintaxe são uma exceção à regra.

- Use S para estruturas, C para classes.
- Use M para métodos.
- Use v para variáveis, p para parâmetros.
- Use r para ref parâmetros.


## Style guidelines
- Use quatro espaços para recuo. Não use tabulações.
- Alinhe o código de forma consistente para melhorar a legibilidade.
- Limite as linhas a 65 caracteres para melhorar a legibilidade do código em documentos, especialmente em telas de dispositivos móveis.
- Divida declarações longas em várias linhas para melhorar a clareza.
- Use o estilo "Allman" para chaves: chaves de abertura e fechamento são sua própria nova linha. Chaves se alinham com o nível de recuo atual.
- Quebras de linha devem ocorrer antes de operadores binários, se necessário.