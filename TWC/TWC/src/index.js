import ReactDOM from 'react-dom';
import App from './features/root/App';
import store from './app/store';
import { Provider } from 'react-redux';
import { BrowserRouter } from 'react-router-dom';
import inject from './inject'
import 'alertifyjs/build/css/alertify.min.css';
import 'animate.css/animate.min.css';
import 'animate.css';
import './index.css';



inject(ReactDOM,App,Provider,BrowserRouter,store);


// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals

