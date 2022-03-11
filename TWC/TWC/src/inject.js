import React from 'react'

const inject = (
    ParamsDom, ParamsApp, ParamsProvider, ParamsRouter, ParamsStore
) => {
    const rootElement = document.getElementById('root');
    return {
        obj: ParamsDom.render(<ParamsProvider store={ParamsStore}>
            <ParamsRouter>
                <ParamsApp />
            </ParamsRouter>
        </ParamsProvider>, rootElement)
    }
}

export default inject