import React from 'react';
import ReactDOM from 'react-dom';
import App from './features/root/App';
import store from './app/store';
import { Provider } from 'react-redux';
import { BrowserRouter } from 'react-router-dom';
import 'alertifyjs/build/css/alertify.min.css';
import 'animate.css/animate.min.css';
import 'animate.css';
import './index.css';

const rootElement = document.getElementById('root');

const renderer = () => {
    return {
        obj: ReactDOM.render(
            <Provider store={store}>
                <BrowserRouter>
                    <App />
                </BrowserRouter>
            </Provider>,
            rootElement
        )
    };
};

renderer();


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals

