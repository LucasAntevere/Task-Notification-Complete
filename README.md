# Tasks Notification Exercise

Os usuários do seu aplicativo de organização de tarefas desejam receber um e-mail com suas tarefas seguindo a prioridade definida por eles para cada item. Você como desenvolvedor, decide utilizar o **Composite Pattern** para gerar uma **Lista Ordenada** em **HTML** para as tarefas dos usuários, sendo assim possível encaminhá-las por e-mail de forma organizada.
Tendo definido o arquivo Tasks.json abaixo com uma lista de tarefas de um usuário:

    [
        {
            "priority": "1",
            "description": "Cuidar dos doguinhos"
        },
        {
            "priority": "1.1",
            "description": " Colocar água pro Geraldo"
        },
        
						    …
    
        {
            "priority": "3",
            "description": "Estudar SOLID"
        },
    ]

Crie um programa usando **Composite Pattern** que retorne uma **lista ordenada** em **HTML**, como mostra o exemplo abaixo:

    <ol>
    	<li>Cuidar dos doguinhos</li>
    	<ol>
    		<li> Colocar água pro Geraldo</li>
    	</ol>    
    			    ...    
				    
    	<li>Estudar SOLID</li>
    </ol>

Dessa maneira, a lista de tarefas será exibida no e-mail da seguinte maneira:

1. Cuidar dos doguinhos
		1. Colocar água pro Geraldo
		2. Ração especial pra Shirley
			1. Apenas de manhã e à noite em pouca quantidade
2. Abastecer dispensa
		1. Comprar ovos
		2. Fazer varejão
				1. Beterraba
				2. Melancia
				3. Pepino
3. Estudar SOLID
