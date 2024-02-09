const msgerForm = get(".msger-inputarea");
const msgerInput = get(".msger-input");
const msgerChat = get(".msger-chat");


const BOT_IMG = "../Resources/chat_portrait.png";
const PERSON_IMG = "../Resources/Portraits/player.png";
const BOT_NAME = "Bartender";
const PERSON_NAME = "user";

import { apiKey, apiUrl } from './config.js';


// 마우스 오른쪽 클릭 방지
document.addEventListener('contextmenu', function (e) {
    e.preventDefault();
});


msgerForm.addEventListener("submit", event => {
    event.preventDefault();

    const msgText = msgerInput.value;
    if (!msgText) return;

    appendMessage(PERSON_NAME, PERSON_IMG, "right", msgText);
    botResponse(msgText);

    msgerInput.value = "";
});

function botResponse(prompt) {
    //GPT 명령 생성
    const converse = [
        {
            role: 'system', content:
                'you are a bartender from bar. user is customer to bar with worries. At first, you should ask customer what to order. when solving user problem, recommend cocktail that best describes solution' },
        { role: 'user', content: prompt }
    ];

    axios.post(apiUrl, {
        model: 'gpt-3.5-turbo-0125',
        messages: converse,
        temperature: 0.3,
        frequency_penalty: 1,
        presence_penalty: 0.5,
    }, {
        headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${apiKey}`,
        },
    })
        .then(response => {
            //생성된 답변을 출력
            const generatedText = response.data.choices[0].message.content;
            appendMessage(BOT_NAME, BOT_IMG, "left", generatedText);
        })
        .catch(error => {
            console.error('Error:', error);
        });
}

function appendMessage(name, img, side, text) {
    const msgHTML = `
    <div class="msg ${side}-msg">
      <div class="msg-img" style="background-image: url(${img})"></div>

      <div class="msg-bubble">
        <div class="msg-info">
          <div class="msg-info-name">${name}</div>
          <div class="msg-info-time">${formatDate(new Date())}</div>
        </div>

        <div class="msg-text">${text}</div>
      </div>
    </div>
  `;

    msgerChat.insertAdjacentHTML("beforeend", msgHTML);
    msgerChat.scrollTop += 500;
}

function get(selector, root = document) {
    return root.querySelector(selector);
}

function formatDate(date) {
    const h = "0" + date.getHours();
    const m = "0" + date.getMinutes();

    return `${h.slice(-2)}:${m.slice(-2)}`;
}
