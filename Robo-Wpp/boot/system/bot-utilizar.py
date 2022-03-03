from selenium import webdriver
import time
from selenium.webdriver.common.keys import Keys
import requests
############################# VARIAVEIS DE CONTROLE 




######################FUNÇÕES DO BOT

def ClicaBolinha():#lembre, python, termina o processamento com a identação do código		
	#PEGA A BOLINHA VERDE
	#metodo estava confundindo o alerta de notificação com conversa silenciada
	#bolinha = driver.find_element_by_class_name('_1pJ9J')
	#bolinha = driver.find_elements_by_class_name('_1pJ9J')
	bolinha = driver.find_element_by_class_name('aumms1qt')
	bolinha = driver.find_elements_by_class_name('aumms1qt')	
	clica_bolinha = bolinha[-1]	 
	acao_bolinha = webdriver.common.action_chains.ActionChains(driver)
	acao_bolinha.move_to_element_with_offset(clica_bolinha,0,-20)
	acao_bolinha.click()
	acao_bolinha.perform()
	acao_bolinha.click()
	acao_bolinha.perform()


def ClicaFixa():
	#VOLTAR PARA O CONTATO PADRÃO
	contato_padrao = driver.find_element_by_class_name('_2XH9R')
	acao_contato = webdriver.common.action_chains.ActionChains(driver)
	acao_contato.move_to_element_with_offset(contato_padrao,0,-20)
	acao_contato.click()
	acao_contato.perform()
	acao_contato.click()
	acao_contato.perform()#parece que é para clicar e ficar em cima, só o clique é click


def infoCliente():
	#PEGA O TELEFONE DO CLIENTE 
	#AQUI PEGA O NÚMERO E O NOME DA PESSOA
	contato_cliente = driver.find_element_by_xpath('//*[@id="main"]/header/div[2]/div/div/span')
	contato = contato_cliente.text
	return contato
	


def menssagem():
	#PEGA A MENSAGEM DO CLIENTE
	todas_as_msg = driver.find_elements_by_class_name('_1Gy50')
	todas_as_msg_texto = [e.text for e in todas_as_msg]
	msg = todas_as_msg_texto[-1]
	return msg

def ClicaContatoCabecalho():
	#CLICA NO CABEÇALHO PARA ABRIR O MENU E PEGAR O NOME 
	cabecalho_busca = driver.find_element_by_xpath('//*[@id="main"]/header/div[2]/div/div/span')
	cabecalho_busca.click()


#############################################BOT DE RESPOSTA E LEITURA
driver = webdriver.Chrome()
driver.get('https://web.whatsapp.com/')
time.sleep(15)


def bot():
	ClicaFixa()
	try:
		ClicaBolinha()		
		
		telefone = infoCliente()
		print(telefone)
		
		msg = menssagem()
		print(msg)

		campo_de_texto = driver.find_element_by_xpath('//*[@id="main"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[2]')
		campo_de_texto.click()

		resposta = requests.get("http://www.strtec.com.br/boot/index.php", params={'msg': {msg},'telefone':{telefone}, 'nome':{''}})
		bot_resposta = resposta.text
		

		time.sleep(3)
		campo_de_texto.send_keys(bot_resposta, Keys.ENTER)

		ClicaFixa()

		
	except:
		print('buscando novas mensagens')
		time.sleep(3)


while True:
	bot()		


