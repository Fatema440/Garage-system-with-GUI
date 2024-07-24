
#include <avr/io.h>
#include "LCD.h"
#include "timer.h"
#define F_CPU 1000000UL
#include <util/delay.h>
#include <avr/interrupt.h>
#include "USART.h"
#include "std_macros.h"
char x;
char flag1=0,flag2=0,IR1,IR2,counter=0;
char free_slots = 99;


void segment_display(char n){
	
	const char seg[10] ={0x3f,0x06,0x5B,0x4f,0x66,0x6D,0x7D,0x07,0x7f,0x6f}; // common cathode
	SET_BIT(PORTC,6);
	PORTA = seg[n%10]<<1;    // ones
	CLR_BIT(PORTC,7);
	
	_delay_ms(1);
	SET_BIT(PORTC,7);
	PORTA = seg[n/10]<<1;   //tens
	CLR_BIT(PORTC,6);
	_delay_ms(1);
}
void open_gate1(){
	
	 timer1_wave_fastPWM_B(0.999999);
	 _delay_ms(500);
	 timer1_wave_fastPWM_B(1.499999);
	 counter++;
	 free_slots = 99-counter;
	 //segment_display(free_slots);
	 LCD_movecursor(1,11);
	 LCD_vSend_char(counter+48);
	 char d1 = free_slots/10;
	 char d0 = free_slots%10;
	 UART_vSendData('@');
	 UART_vSendData(d1+48);
	 UART_vSendData(d0+48);
	 UART_vSendData('!');
}
void open_gate2(){
	 timer1_wave_fastPWM_A(0.999999);
	 _delay_ms(500);
	 timer1_wave_fastPWM_A(1.499999);
	  counter--;
	  free_slots = 99-counter;
	  //segment_display(free_slots);
	  LCD_movecursor(1,11);
	  LCD_vSend_char(counter+48); 
	  char d1 = free_slots/10;
	  char d0 = free_slots%10;
	  UART_vSendData('@');
	  UART_vSendData(d1+48);
	  UART_vSendData(d0+48);
	  UART_vSendData('!'); 
}
int main(void)
{   
	DDRA = 0xff;
	LCD_vInit();
	UART_vInit(2400);
	sei();
	// PORTC PIN 6 , 7
	SET_BIT(DDRC,6);
	SET_BIT(DDRC,7);

	SET_BIT(DDRC,0);
	SET_BIT(DDRC,1);
	
	LCD_vSend_string("there are 0 cars");
	LCD_movecursor(2,1);
	LCD_vSend_string("garage has space");

	char n1 = free_slots/10;
	char n0 = free_slots%10;
	UART_vSendData('@');
	UART_vSendData(n1+48);
	UART_vSendData(n0+48);
	UART_vSendData('!');
	
    while(1)
    {
        
		 IR1=DIO_u8read('D',6);
		 if(IR1==1 && flag1==0 && counter<99)
		 {
			 
			 UART_vSendData('i');
			 
			 flag1=1;
		
			 
		 }
		 else if(IR1==0)
		 {
			 flag1=0;
		 }
		 
		 IR2=DIO_u8read('D',7);
		 if(IR2==1 && flag2==0 && counter>0)
		 {
			
			 UART_vSendData('o');
			 flag2=1;

		 }
		 else if(IR2==0)
		 {
			 flag2=0;
		 }
		 segment_display(free_slots);
    }
	
	return 0;
}

ISR(USART_RXC_vect){
	
	x=UDR;
	
	if(x=='1'){
		open_gate1();
	}
	else if(x=='2'){
		open_gate2();
	}
	else if (x == '3'){
		SET_BIT(PORTC,1);
		_delay_ms(2000);
		CLR_BIT(PORTC,1);
	}
	else if (x == '4'){
		SET_BIT(PORTC,0);
		_delay_ms(2000);
		CLR_BIT(PORTC,0);
	}
}
