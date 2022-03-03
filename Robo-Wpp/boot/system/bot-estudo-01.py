from selenium import webdriver
import time 
from selenium.webdriver.common.keys import Keys 
import requests

driver = webdriver.Chrome()#aqui muda o navegador 
#Adiciona uma variavel ao objeto chrome pelo webdriver 
#Colocando as funções de acesso que o objeto tem, que foi importado do webdriver

driver.get("https://web.whatsapp.com/")
time.sleep(10)
#Abre a página do wpp no navegador 
#Adiciona tempo para o qr code ser escaniado 
	def begin():
		print("iniciando operação")

	def bot(): 	
	#Cria a função que irá clicar se houver nova menssagem, através do conhecido try catch 
	#estrutura semelhante outras linguagens mas, sendo simplificada
	try:
		bolinha = driver.find_element_by_class_name('_1pJ9J')# -> se faz assim quando precisa pegar apenas um elementento
		#procura a classe da bolinha para saber se tem novas menssagens
		bolinha = driver.find_elements_by_class_name('_1pJ9J')#para pegar mais de uma classe, se usa dessa forma 
		clica_bolinha = bolinha[-2]
		#posição do array para pegar a nova menssagem
		acao_bolinha = webdriver.common.action_chains.ActionChains(driver)
		#Se cria uma ação no crhome instanciando um objeto
		acao_bolinha.move_to_element_with_offset(clica_bolinha,0,-22)
		#Instancia qual elemento vai ser movimentado dentro da função que será executada na classe 
		acao_bolinha.click()
		#Metodo para clicar em cima da conversa
		acao_bolinha.perform()
		acao_bolinha.click()
		acao_bolinha.perform()

		#PEGA O NÚMERO
		telefone_client = driver.find_element_by_xpath('//*[@id="main"]/header/div[2]/div/div/span')#como é um elemento por inteiro e pelo path
		#não pode ser elements, tem que ser element
		telefone = telefone_client.text #Transforma o telefone do cliente em texto
		print(telefone)

		#PEGA A ÚLTMA MENSSAGEM
		todas_as_menssagens = driver.find_elements_by_class_name('_1Gy50')
		Tds_msg_txt = [e.text for e in todas_as_menssagens]
		msg = Tds_msg_txt[-1]
		print(msg)

		

		#FAZ VOLTAR PARA O CONTATO FIXADO
		fixa = driver.find_element_by_class_name('_2XH9R')
		acao_fixa = webdriver.common.action_chains.ActionChains(driver)
		acao_fixa.move_to_element_with_offset(fixa,0,-22)
		acao_fixa.click()
		acao_fixa.perform()
		acao_fixa.click()
		acao_fixa.perform()		
		
	except:
		time.sleep(3)
		print('Procurando novas messagens')

while True: 
	bot()


	##bot usando -> script para não perder 
	clica_bolinha = bolinha[-2]
		#posição do array para pegar a nova menssagem
		acao_bolinha = webdriver.common.action_chains.ActionChains(driver)
		#Se cria uma ação no crhome instanciando um objeto
		acao_bolinha.move_to_element_with_offset(clica_bolinha,0,-22)
		#Instancia qual elemento vai ser movimentado dentro da função que será executada na classe 
		acao_bolinha.click()
		#Metodo para clicar em cima da conversa
		acao_bolinha.perform()
		acao_bolinha.click()
		acao_bolinha.perform()

		#PEGA O NÚMERO
		telefone_client = driver.find_element_by_xpath('//*[@id="main"]/header/div[2]/div/div/span')#como é um elemento por inteiro e pelo path
		#não pode ser elements, tem que ser element
		telefone = telefone_client.text #Transforma o telefone do cliente em texto
		print(telefone)

		#PEGA A ÚLTMA MENSSAGEM
		todas_as_menssagens = driver.find_elements(By.CLASS_NAME,'_1Gy50')
		Tds_msg_txt = [e.text for e in todas_as_menssagens]
		msg = Tds_msg_txt[-1]
		print(msg)

		

		#FAZ VOLTAR PARA O CONTATO FIXADO
		fixa = driver.find_element(By.CLASS_NAME,'_2XH9R')
		acao_fixa = webdriver.common.action_chains.ActionChains(driver)
		acao_fixa.move_to_element_with_offset(fixa,0,-22)
		acao_fixa.click()
		acao_fixa.perform()
		acao_fixa.click()
		acao_fixa.perform()		
		
	except:
		time.sleep(3)
		print('Procurando novas messagens')

while True: 
	bot()

	##########################################################

	

from selenium import webdriver
import time 
from selenium.webdriver.common.keys import Keys 
import requests

driver = webdriver.Chrome()#aqui muda o navegador 
#Adiciona uma variavel ao objeto chrome pelo webdriver 
#Colocando as funções de acesso que o objeto tem, que foi importado do webdriver

driver.get("https://web.whatsapp.com/")
time.sleep(15)
#Abre a página do wpp no navegador 
#Adiciona tempo para o qr code ser escaniado 

fixa = driver.find_element_by_class_name('_2XH9R')
acao_fixa = webdriver.common.action_chains.ActionChains(driver)
acao_fixa.move_to_element_with_offset(fixa,0,-22)
acao_fixa.click()
acao_fixa.perform()
acao_fixa.click()
acao_fixa.perform()	
def bot(): 	
	#Cria a função que irá clicar se houver nova menssagem, através do conhecido try catch 
	#estrutura semelhante outras linguagens mas, sendo simplificada
	try:
		bolinha = driver.find_element_by_class_name('_1pJ9J')# -> se faz assim quando precisa pegar apenas um elementento
		#procura a classe da bolinha para saber se tem novas menssagens
		bolinha = driver.find_elements_by_class_name('_1pJ9J')#para pegar mais de uma classe, se usa dessa forma 
		clica_bolinha = bolinha[-2]
		#posição do array para pegar a nova menssagem
		acao_bolinha = webdriver.common.action_chains.ActionChains(driver)
		#Se cria uma ação no crhome instanciando um objeto
		acao_bolinha.move_to_element_with_offset(clica_bolinha,0,-22)
		#Instancia qual elemento vai ser movimentado dentro da função que será executada na classe 
		acao_bolinha.click()
		#Metodo para clicar em cima da conversa
		acao_bolinha.perform()
		acao_bolinha.click()
		acao_bolinha.perform()

		#PEGA O NÚMERO
		telefone_client = driver.find_element_by_xpath('//*[@id="main"]/header/div[2]/div/div/span')#como é um elemento por inteiro e pelo path
		#não pode ser elements, tem que ser element
		telefone = telefone_client.text #Transforma o telefone do cliente em texto
		print(telefone)

		#PEGA A ÚLTMA MENSSAGEM
		todas_as_menssagens = driver.find_elements_by_class_name('_1Gy50')
		Tds_msg_txt = [e.text for e in todas_as_menssagens]
		msg = Tds_msg_txt[-1]
		print(msg)		

		#RESPONDER A MENSAGEM
		campo_de_texto = driver.find_element_by_xpath('//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[2]')
		campo_de_texto.click()
		resposta = requests.get("http://strtec.com.br/index.php", params={'msg': {msg},'telefone':{telefone_final}})
		bot_resposta = resposta.text
		time.sleep(3)
		campo_de_texto.send_keys('teste', Keys.ENTER)


		#FAZ VOLTAR PARA O CONTATO FIXADO
		fixa = driver.find_element_by_class_name('_2XH9R')
		acao_fixa = webdriver.common.action_chains.ActionChains(driver)
		acao_fixa.move_to_element_with_offset(fixa,0,-22)
		acao_fixa.click()
		acao_fixa.perform()
		acao_fixa.click()
		acao_fixa.perform()		


		
	except:
		time.sleep(3)
		print('Procurando novas messagens')

while True: 
	bot()